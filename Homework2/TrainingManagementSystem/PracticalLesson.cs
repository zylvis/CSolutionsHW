using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class PracticalLesson
    {
        public string TaskCondition { get; set; }
        public string Solution { get; set; }

        public PracticalLesson(string taskCondition, string solution)
        {
            TaskCondition = taskCondition;
            Solution = solution;
        }

    }
}
