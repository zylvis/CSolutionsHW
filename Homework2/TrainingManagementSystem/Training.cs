using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Training : Description
    {
        
        private Lecture _lecture;
        private PracticalLesson _practicalLesson;
        public Training(Lecture lecture, PracticalLesson practicalLesson, string lectureDescription, string practicalDescription, string trainingDescription) 
            : base(lectureDescription, practicalDescription, trainingDescription)
        {
            this.LectureDescription = lectureDescription;
            this.PracticalDescription = practicalDescription;   
            this.TrainingDescription = trainingDescription;
            this._lecture = lecture;
            this._practicalLesson = practicalLesson;
        }
        
        public Dictionary<Lecture, PracticalLesson> SetOfObjects { get; set; } = new Dictionary<Lecture, PracticalLesson>();

        public Dictionary<Lecture, PracticalLesson> Add(Lecture lecture, PracticalLesson practicalLesson)
        {
            if (_lecture != null)
            {
                SetOfObjects.Add(lecture, practicalLesson);
            }
            return SetOfObjects;
        }

        public bool IsPractical()
        {
            if (SetOfObjects.ContainsKey(_lecture))
            {
                return false;
            }
            return true;
        }

        public Training Clone()
        {
            Training training = new(_lecture, _practicalLesson, this.LectureDescription, this.PracticalDescription, this.TrainingDescription);
            return training;
        }
    }
}
