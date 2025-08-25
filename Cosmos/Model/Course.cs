using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Model
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Stage> Stages { get; set; }

        public Course(int iD, string name, List<Stage> stages)
        {
            ID = iD;
            Name = name;
            Stages = stages;
        }
    }
}
