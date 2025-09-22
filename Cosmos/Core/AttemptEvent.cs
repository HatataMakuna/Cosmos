using Cosmos.Data;
using Cosmos.Model;
using Cosmos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Cosmos.Core
{
    public class AttemptEvent
    {
        private Dictionary<string, double> obstacleStats;
        private InitData data;
        public event EventHandler<MessageEventArgs> OnMessage;
        public event PropertyChangedEventHandler PropertyChanged;

        public AttemptEvent(InitData data)
        {
            this.data = data ?? throw new ArgumentNullException(nameof(data));
        }

        public void AttemptObstacle(Player player, Channel channel)
        {
            // Calculate the player's effective stats against the obstacle's tags
            double obstacleTotalStats = channel.GetObstacleStats().Values.Sum();
            double playerTotalStats = player.GetTotalStats();
            double playerEffectiveness = CalculatePlayerEffectiveness(player, channel);

            // Calculate the success chance based on player effectiveness and obstacle stats
            double successChanceFactor = ((playerTotalStats * playerEffectiveness) / obstacleTotalStats) * 100;
            if (successChanceFactor > 95)
            {
                successChanceFactor = 95; // Cap at 95% success chance
            }
            else if (successChanceFactor <= 0)
            {
                successChanceFactor = 0; // Minimum success chance
            }

            // Simulate a random success chance
            Random rand = new Random();
            double successChance = rand.NextDouble() * 100; // Random value between 0 and 100

            // Check if the player successfully completes the obstacle
            if (successChance <= successChanceFactor)
            {
                RaiseMessage($"Player {player.name} successfully completed the obstacle: {channel.currentObstacle.name}.");
                AddExperience(player, channel.currentLevel); // Award experience based on difficulty
                player.noCompletedObstacles++; // Increment completed obstacles count
                channel.currentLevel++; // Increment the channel's level
                channel.currentObstacle = data.GetRandomObstacle(); // Refresh the current obstacle with a new one

                // Call the OnObstacleCompleted event to change the current obstacle and level
                OnPropertyChanged("currentObstacle");
            }
            else
            {
                RaiseMessage($"Player {player.name} failed to complete the obstacle: {channel.currentObstacle.name}.");
            }
            player.noAttemptedObstacles++; // Increment attempted obstacles count
            channel.totalAttempts++;

            // Ensure the uniquePlayerIds HashSet is initialized
            if (channel.uniquePlayerIds == null)
            {
                channel.uniquePlayerIds = new HashSet<int>();
            }

            // add unique players logic; if same player hit attempt, don't add
            if (!channel.uniquePlayerIds.Contains(player.ID))
            {
                channel.uniquePlayerIds.Add(player.ID);
            }

            // Modify last attempted to time now
            channel.lastAttempted = DateTime.Now;
        }

        // Calculate player effectiveness against the obstacle (based on obstacle tags)
        private double CalculatePlayerEffectiveness(Player player, Channel channel)
        {
            double effectiveness = 0;
            obstacleStats = channel.GetObstacleStats();

            // Check obstacle tags and calculate effectiveness based on player stats
            if (channel.currentObstacle.tags.Contains("climbing"))
            {
                effectiveness += (player.strength + player.grip) / (obstacleStats["strength"] + obstacleStats["grip"]);
            }
            else if (channel.currentObstacle.tags.Contains("balance"))
            {
                effectiveness += (player.balance + player.agility) / (obstacleStats["balance"] + obstacleStats["agility"]);
            }
            else if (channel.currentObstacle.tags.Contains("strength"))
            {
                effectiveness += (player.strength + player.endurance) / (obstacleStats["strength"] + obstacleStats["endurance"]);
            }
            else if (channel.currentObstacle.tags.Contains("tech"))
            {
                effectiveness += (player.tech + player.intelligence) / (obstacleStats["tech"] + obstacleStats["intelligence"]);
            }
            else if (channel.currentObstacle.tags.Contains("speed"))
            {
                effectiveness += (player.speed + player.agility) / (obstacleStats["speed"] + obstacleStats["agility"]);
            }
            else if (channel.currentObstacle.tags.Contains("grip"))
            {
                effectiveness += (player.grip + player.strength) / (obstacleStats["grip"] + obstacleStats["strength"]);
            }
            else if (channel.currentObstacle.tags.Contains("endurance"))
            {
                effectiveness += (player.endurance + player.stamina) / (obstacleStats["endurance"] + obstacleStats["stamina"]);
            }
            else if (channel.currentObstacle.tags.Contains("lache"))
            {
                effectiveness += (player.lache + player.agility) / (obstacleStats["lache"] + obstacleStats["agility"]);
            }
            else if (channel.currentObstacle.tags.Contains("intelligence"))
            {
                effectiveness += (player.intelligence + player.tech) / (obstacleStats["intelligence"] + obstacleStats["tech"]);
            }

            // If the obstacle has multiple tags, use average for their effectiveness
            if (channel.currentObstacle.tags.Count > 1)
                effectiveness /= channel.currentObstacle.tags.Count;

            // If the obstacle has no tags, consider all stats equally
            if (effectiveness == 0)
                effectiveness = 1; // Default effectiveness if no tags match

            return effectiveness;
        }

        public void AddExperience(Player player, int amount)
        {
            int previousLevel = player.level;
            player.experience += amount;
            int newLevel = player.level;
            RaiseMessage($"Player {player.name} gained {amount} experience.");

            // If player levelled up, add available points
            if (newLevel > previousLevel)
            {
                RaiseMessage($"Player {player.name} leveled up to level {newLevel}!");

                // Only add available points if the player is not a competitor
                if (!player.isCompetitor) player.availablePoints += (newLevel - previousLevel);
            }
        }

        private void RaiseMessage(string message, bool addExtraNewLine = false)
        {
            if (OnMessage != null)
            {
                OnMessage(this, new MessageEventArgs(message, addExtraNewLine));
            }
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
