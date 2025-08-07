using Cosmos.Data;
using System;
using System.Collections.Generic;

namespace Cosmos.Model
{
    [Serializable]
    public class Channel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int currentLevel { get; set; } // Current obstacle level of the channel
        public Obstacle currentObstacle { get; set; } // Current obstacle in the channel
        public int totalAttempts { get; set; } = 0;
        public DateTime lastAttempted { get; set; } = DateTime.MinValue;

        // A HashSet in C# is an unordered collection that
        // stores unique elements, preventing duplicates.
        public HashSet<int> uniquePlayerIds = new HashSet<int>();

        public Channel(int id, string name, int currentLevel, Obstacle currentObstacle)
        {
            ID = id;
            this.name = name;
            this.currentLevel = currentLevel;
            this.currentObstacle = currentObstacle ?? throw new ArgumentNullException(nameof(currentObstacle));
        }

        public Dictionary<string, double> GetObstacleStats()
        {
            if (currentObstacle == null)
                return new Dictionary<string, double>();
            
            var stats = new Dictionary<string, double>
            {
                { "speed", currentObstacle.speed },
                { "tech", currentObstacle.tech },
                { "grip", currentObstacle.grip },
                { "strength", currentObstacle.strength },
                { "endurance", currentObstacle.endurance },
                { "agility", currentObstacle.agility },
                { "balance", currentObstacle.balance },
                { "lache", currentObstacle.lache },
                { "stamina", currentObstacle.stamina },
                { "intelligence", currentObstacle.intelligence }
            };

            string[] statNames = { "speed", "tech", "grip", "strength", "endurance", "agility", "balance", "lache", "stamina", "intelligence" };
            Random rand = new Random();
            
            for (int i = 0; i < currentLevel; i++)
            {
                // Select 3 random stats to increase per current level
                for (int j = 0; j < 3; j++)
                {
                    int randomIndex = rand.Next(statNames.Length);
                    string statName = statNames[randomIndex];
                    stats[statName] += 1; // Increase the stat by 1
                }
            }

            // Check obstacle tags and apply additional modifications
            if (currentObstacle.tags.Contains("climbing"))
            {
                stats["strength"] += 2; // Increase strength for climbing obstacles
                stats["grip"] += 1; // Increase grip for climbing obstacles
            } else if (currentObstacle.tags.Contains("balance"))
            {
                stats["balance"] += 2; // Increase balance for balance obstacles
                stats["agility"] += 1; // Increase agility for balance obstacles
            }
            else if (currentObstacle.tags.Contains("strength"))
            {
                stats["strength"] += 3; // Increase strength for strength obstacles
                stats["endurance"] += 1; // Increase endurance for strength obstacles
            }
            else if (currentObstacle.tags.Contains("tech"))
            {
                stats["tech"] += 2; // Increase tech for tech obstacles
                stats["intelligence"] += 1; // Increase intelligence for tech obstacles
            }
            else if (currentObstacle.tags.Contains("speed"))
            {
                stats["speed"] += 2; // Increase speed for speed obstacles
                stats["agility"] += 1; // Increase agility for speed obstacles
            }
            else if (currentObstacle.tags.Contains("grip"))
            {
                stats["grip"] += 2; // Increase grip for grip obstacles
                stats["strength"] += 1; // Increase strength for grip obstacles
            }
            else if (currentObstacle.tags.Contains("endurance"))
            {
                stats["endurance"] += 2; // Increase endurance for endurance obstacles
                stats["stamina"] += 1; // Increase stamina for endurance obstacles
            }
            else if (currentObstacle.tags.Contains("lache"))
            {
                stats["lache"] += 2; // Increase lache for lache obstacles
                stats["agility"] += 1; // Increase agility for lache obstacles
            }
            else if (currentObstacle.tags.Contains("intelligence"))
            {
                stats["intelligence"] += 2; // Increase intelligence for intelligence obstacles
                stats["tech"] += 1; // Increase tech for intelligence obstacles
            }

            return stats;
        }
    }
}