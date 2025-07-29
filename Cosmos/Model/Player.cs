using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos.Model
{
    public class Player
    {
        // Player Info
        public int ID { get; set; }
        public string name { get; set; }
        public double experience { get; set; }
        public int level
        {
            get
            {
                double exp = experience;
                double requiredExp = 10;
                double increment = 10;
                int lvl = 1;

                while (exp >= requiredExp)
                {
                    lvl++;
                    increment += 10;
                    requiredExp += increment;
                }
                return lvl;
            }
        }
        public int availablePoints { get; set; }
        public int noAttemptedObstacles { get; set; }
        public int noCompletedObstacles { get; set; }

        // Stats
        // By default, all stats are set to 10
        public int speed { get; set; }
        public int tech { get; set; }
        public int grip { get; set; }
        public int strength { get; set; }
        public int endurance { get; set; }
        public int agility { get; set; }
        public int balance { get; set; }
        public int lache { get; set; }
        public int stamina { get; set; }
        public int intelligence { get; set; }

        // Constructor to initialize a new player with default stats
        public Player()
        {
            experience = 0; // Initialize experience to 0
            availablePoints = 0;
            noAttemptedObstacles = 0;
            noCompletedObstacles = 0;
            speed = 10;
            tech = 10;
            grip = 10;
            strength = 10;
            endurance = 10;
            agility = 10;
            balance = 10;
            lache = 10;
            stamina = 10;
            intelligence = 10;
        }

        // Constructor to initialize a player with specific values
        public Player(int id, string name, int experience, int availablePoints,
                     int speed, int tech, int grip, int strength, int endurance,
                     int agility, int balance, int lache, int stamina, int intelligence)
        {
            ID = id;
            this.name = name;
            this.experience = experience;
            this.availablePoints = availablePoints;
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

        public double GetExperiencePercentage()
        {
            // lvl = 2; expEnd - expStart = 10 (should be 20)
            double expStart = 0;
            double increment = 10;
            double requiredExp = 10;
            int lvl = 1;
            
            while (lvl < level)
            {
                expStart = requiredExp;
                increment += 10;
                requiredExp += increment;
                lvl++;
            }

            double expEnd = requiredExp;

            if (expEnd == expStart) return 100.0;
            return ((experience - expStart) / (expEnd - expStart) * 100.0);
        }

        // Get player total stats
        public double GetTotalStats()
        {
            return speed + tech + grip + strength + endurance + agility + balance + lache + stamina + intelligence;
        }
    }
}
