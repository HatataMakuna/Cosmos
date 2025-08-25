using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class Stage
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public double TimeLimit { get; set; } // in seconds

        public Stage(string iD, string name, List<Obstacle> obstacles, double timeLimit)
        {
            ID = iD;
            Name = name;
            Obstacles = obstacles;
            TimeLimit = timeLimit;
        }
    }
}
