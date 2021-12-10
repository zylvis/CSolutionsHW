using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Lecture
    {
        public string? DescriptionText { get; set; }
        public string? Topic { get; set; }

        public Lecture(string descriptionText, string topic)
        {
            DescriptionText = descriptionText;
            Topic = topic;
        }
    }
}
