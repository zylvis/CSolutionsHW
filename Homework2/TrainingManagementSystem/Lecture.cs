using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Lecture
    {
        public string? Topic { get; set; }

        public Lecture(string topic) 
        {
            Topic = topic;
        }
    }
}
