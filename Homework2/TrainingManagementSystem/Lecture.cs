using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Lecture : Description
    {
        public string Topic { get; set; }

        public Lecture(string descriptionText, string topic) : base(descriptionText)
        {
            Topic = topic;
        }
        
        public override Lecture Clone()
        {
            Lecture clone = new Lecture(base.DescriptionText, Topic);
            return clone;
        }
    }
}
