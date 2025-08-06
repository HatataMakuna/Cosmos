using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmos.Model
{
    [Serializable]
    public class Obstacle
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public int timeLimit { get; set; } // in seconds, prob change to time range to complete it
        public int requiredLevel { get; set; } // Minimum channel level required to attempt this obstacle
        public List<string> tags { get; set; } // Tags for categorization (e.g., "climbing", "balance", "strength")

        // Obstacle base stats (optional)
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

        // Empty constructor to allow serialization and deserialization
        public Obstacle() { }

        public Obstacle(int id, string name, string description, int difficulty,
                        int requiredLevel, List<string> tags, int timeLimit = 0,
                        double speed = 0.0, double tech = 0.0, double grip = 0.0, double strength = 0.0,
                        double endurance = 0.0, double agility = 0.0, double balance = 0.0,
                        double lache = 0.0, double stamina = 0.0, double intelligence = 0.0)
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

        public static Obstacle CreateFromForm(
            int id,
            string name,
            string description,
            int difficulty,
            int requiredLevel,
            IEnumerable<string> tags,
            string speedText,
            string techText,
            string gripText,
            string strengthText,
            string enduranceText,
            string agilityText,
            string balanceText,
            string lacheText,
            string staminaText,
            string intelligenceText,
            int timeLimit = 0)
        {
            double TryParse(string s) => double.TryParse(s, out var v) ? v : 0.0;

            return new Obstacle(
                id,
                name,
                description,
                difficulty,
                requiredLevel,
                tags?.Select(t => t.ToLower()).Distinct().ToList() ?? new List<string>(),
                timeLimit,
                TryParse(speedText),
                TryParse(techText),
                TryParse(gripText),
                TryParse(strengthText),
                TryParse(enduranceText),
                TryParse(agilityText),
                TryParse(balanceText),
                TryParse(lacheText),
                TryParse(staminaText),
                TryParse(intelligenceText)
            );
        }
    }
}
