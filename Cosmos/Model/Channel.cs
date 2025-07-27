using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class Channel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int currentLevel { get; set; } // Current obstacle level of the channel
        public Obstacle currentObstacle { get; set; } // Current obstacle in the channel

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

            return stats;

            // double totalStats = stats.Values.Sum()
        }
    }
}
