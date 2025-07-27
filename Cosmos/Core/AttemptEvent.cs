using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core
{
    public class AttemptEvent
    {
        private Dictionary<string, double> obstacleStats;

        public void AttemptObstacle(Player player, Channel channel)
        {
            //if (player.level < channel.currentObstacle.requiredLevel)
            //{
            //    Console.WriteLine($"Player {player.name} does not meet the level requirement to attempt {channel.currentObstacle.name}.");
            //    return;
            //}

            // Calculate the player's effective stats against the obstacle's tags
            double obstacleTotalStats = channel.GetObstacleStats().Values.Sum();
            Console.WriteLine($"Obstacle Total Stats: {obstacleTotalStats}");
            double playerTotalStats = player.GetTotalStats();
            Console.WriteLine($"Player Total Stats: {playerTotalStats}");
            double playerEffectiveness = CalculatePlayerEffectiveness(player, channel);
            Console.WriteLine($"Player Effectiveness: {playerEffectiveness}");

            // Calculate the success chance based on player effectiveness and obstacle stats
            double successChanceFactor = ((playerTotalStats * playerEffectiveness) / obstacleTotalStats) * 100;

            // Simulate a random success chance
            Random rand = new Random();
            double successChance = rand.NextDouble() * 100; // Random value between 0 and 100
            Console.WriteLine($"Player {player.name} attempts obstacle: {channel.currentObstacle.name}");
            Console.WriteLine($"Success Chance: {successChanceFactor}% (Random: {successChance})");

            // Check if the player successfully completes the obstacle
            if (successChance <= successChanceFactor)
            {
                Console.WriteLine($"Player {player.name} successfully completed the obstacle: {channel.currentObstacle.name}.");
                //AddExperience(player, channel.currentObstacle.difficulty * 10); // Award experience based on difficulty
            }
            else
            {
                Console.WriteLine($"Player {player.name} failed to complete the obstacle: {channel.currentObstacle.name}.");
            }
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

            if (newLevel > previousLevel)
            {
                player.availablePoints += (newLevel - previousLevel);
            }
        }
    }
}
