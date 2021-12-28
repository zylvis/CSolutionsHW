using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Training : Description
    {
        private const int MAX_SET_NUMBER = 4;
        int existingSetElements;
        private Lecture _lecture;
        private PracticalLesson _practicalLesson;

        public Training(string descriptionText, Lecture lecture, PracticalLesson practicalLesson)
            : base(descriptionText)
        {
            this._lecture = lecture;
            this._practicalLesson = practicalLesson;
            this.existingSetElements = 0;
        }

        public object[] SetOfObjects { get; set; } = new object[MAX_SET_NUMBER];

        internal Lecture Lecture { get => _lecture; set => _lecture = value; }
        internal PracticalLesson PracticalLesson { get => _practicalLesson; set => _practicalLesson = value; }

        public void Add(object obj)
        {
            if (existingSetElements < MAX_SET_NUMBER)
            {
                if (obj is Lecture)
                {
                    SetOfObjects[existingSetElements] = obj;
                    existingSetElements++;

                }
                else if (obj is PracticalLesson)
                {
                    SetOfObjects[existingSetElements] = obj;
                    existingSetElements++;
                }
            }

            else
            {
                throw new Exception("Can't add more");
            }
        }

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
            Training training = new(this.DescriptionText, _lecture, _practicalLesson);
            return training;
        }
    }
}
