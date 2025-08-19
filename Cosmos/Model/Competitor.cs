using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class Competitor : Player
    {
        public string nationality { get; set; }

        // Competitor Type
        // 0 - Unknown
        // 1 - Ninja
        // 2 - OCR
        // 3 - Sportsman
        // 4 - Climber
        // 5 - Fictional
        public int type { get; set; }
        public bool isFemale { get; set; }

        public Competitor(
            // Base (Player) arguments
            int id, string name, int experience, int availablePoints,
            int speed, int tech, int grip, int strength, int endurance,
            int agility, int balance, int lache, int stamina,
            int intelligence, bool isCompetitor,
            // Competitor specific arguments
            string nationality, int type, bool isFemale) :
            base(id, name, experience, availablePoints,
                 speed, tech, grip, strength, endurance,
                 agility, balance, lache, stamina,
                 intelligence, isCompetitor)
        {
            this.nationality = nationality;
            this.type = type;
            this.isFemale = isFemale;
        }
    }
}
