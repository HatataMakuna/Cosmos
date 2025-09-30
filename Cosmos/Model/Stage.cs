using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    [Serializable]
    public class Stage
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public bool HasTimeLimit { get; set; } = false;
        public double TimeLimit { get; set; } // in seconds

        public Stage(string iD, string name, List<Obstacle> obstacles, bool hasTimeLimit, double timeLimit)
        {
            ID = iD;
            Name = name;
            Obstacles = obstacles;
            HasTimeLimit = hasTimeLimit;
            TimeLimit = timeLimit;
        }

        override
        public string ToString()
        {
            return $"Stage ID: {ID}, Name: {Name}, Obstacles: {Obstacles.Count}, HasTimeLimit: {HasTimeLimit}, TimeLimit: {TimeLimit}s";
        }
    }
}
