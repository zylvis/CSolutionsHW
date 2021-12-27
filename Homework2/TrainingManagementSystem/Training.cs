using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagementSystem.Extensions;

namespace TrainingManagementSystem
{
    internal class Training : Description
    {
        private const int MAX_SET_NUMBER = 4;
        int existingSetElemenets;
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
            this.existingSetElemenets = 0;
        }

        public object[] SetOfObjects { get; set; } = new object[MAX_SET_NUMBER];

        internal Lecture Lecture { get => _lecture; set => _lecture = value; }
        internal PracticalLesson PracticalLesson { get => _practicalLesson; set => _practicalLesson = value; }

        public void Add(object obj)
        {
            if (existingSetElemenets < MAX_SET_NUMBER)
            {
                if (obj is Lecture)
                {
                    SetOfObjects[existingSetElemenets] = obj;
                    existingSetElemenets++;

                }
                else if (obj is PracticalLesson)
                {
                    SetOfObjects[existingSetElemenets] = obj;
                    existingSetElemenets++;
                }
            }

            else
            {
                throw new Exception("Can't hire more");

            }

        }


        //public Dictionary<Lecture, PracticalLesson> SetOfObjects { get; set; } = new Dictionary<Lecture, PracticalLesson>();


        //public Dictionary<Lecture, PracticalLesson> Add(Lecture lecture, PracticalLesson practicalLesson)
        //{
        //    if (_lecture != null)
        //    {
        //        SetOfObjects.Add(lecture, practicalLesson);
        //    }
        //    return SetOfObjects;
        //}

        public bool IsPractical()
        {
            if (SetOfObjects.Contains(PracticalLesson))
            {
                return true;
            }
            return false;
        }

        public Training Clone()
        {
            Training training = new(_lecture, _practicalLesson, this.LectureDescription, this.PracticalDescription, this.TrainingDescription);
            return training;
        }
    }
}
