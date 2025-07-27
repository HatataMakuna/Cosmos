using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class Obstacle
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public int timeLimit { get; set; } // Time limit in seconds to complete the obstacle
        public int requiredLevel { get; set; } // Minimum player level required to attempt the obstacle
        public List<string> tags { get; set; } // Tags for categorization (e.g., "climbing", "balance", "strength")

        // Obstacle base stats
        public double speed { get; set; }
        public double tech { get; set; }
        public double grip { get; set; }
        public double strength { get; set; }
        public double endurance { get; set; }
        public double agility { get; set; }
        public double balance { get; set; }
        public double lache { get; set; }
        public double stamina { get; set; }
        public double intelligence { get; set; }

        public Obstacle(int id, string name, string description, int difficulty, int timeLimit, int requiredLevel, List<string> tags,
                        double speed, double tech, double grip, double strength, double endurance, double agility, double balance, double lache, double stamina, double intelligence)
        {
            ID = id;
            this.name = name;
            this.description = description;
            this.difficulty = difficulty;
            this.timeLimit = timeLimit;
            this.requiredLevel = requiredLevel;
            this.tags = tags ?? new List<string>();
            this.speed = speed;
            this.tech = tech;
            this.grip = grip;
            this.strength = strength;
            this.endurance = endurance;
            this.agility = agility;
            this.balance = balance;
            this.lache = lache;
            this.stamina = stamina;
            this.intelligence = intelligence;
        }
    }
}
