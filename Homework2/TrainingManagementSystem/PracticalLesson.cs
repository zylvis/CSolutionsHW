using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class PracticalLesson
    {
        public string DescriptionText { get; set; } 
        public string TaskCondition { get; set; }
        public string Solution { get; set; }

        public PracticalLesson(string descriptionText, string taskCondition, string solution)
        {
            DescriptionText = descriptionText;  
            TaskCondition = taskCondition;
            Solution = solution;
        }

    }
}
