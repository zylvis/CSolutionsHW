using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    public class PracticalLesson : Description
    {
        public string TaskCondition { get; set; }
        public string Solution { get; set; }

        public PracticalLesson(string descriptionText, string taskCondition, string solution) : base(descriptionText)
        {
            TaskCondition = taskCondition;
            Solution = solution;
        }

        public override PracticalLesson Clone()
        {
            PracticalLesson clone = new PracticalLesson(base.DescriptionText, TaskCondition, Solution);
            return clone;
        }

    }
}
