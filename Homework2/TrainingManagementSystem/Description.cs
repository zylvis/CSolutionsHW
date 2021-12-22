using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    abstract class Description
    {
        public string LectureDescription { get; set; }
        public string PracticalDescription { get; set; }
        public string TrainingDescription { get; set; }

        public Description(string lectureDescription, string practicalDescription, string trainingDescription)
        {
            LectureDescription = lectureDescription;
            PracticalDescription = practicalDescription;
            TrainingDescription = trainingDescription;
        }
    }
}
