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

        public Description[] SetOfObjects { get; set; } = new Description[MAX_SET_NUMBER];

        public void Add(Description description)
        {
            if (existingSetElements < MAX_SET_NUMBER)
            {
                if (description is Lecture)
                {
                    SetOfObjects[existingSetElements] = description;
                    existingSetElements++;

                }
                else if (description is PracticalLesson)
                {
                    SetOfObjects[existingSetElements] = description;
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
            int count = 0;
            foreach (Description description in SetOfObjects)
            {
                if (description is PracticalLesson)
                {
                    count++;
                }
            }

            return count > 0;
            
        }

        public Training Clone()
        {
            Training training = (Training)this.MemberwiseClone();
            training._lecture = new Lecture(_lecture.DescriptionText, _lecture.Topic);
            training._practicalLesson = new PracticalLesson(_practicalLesson.DescriptionText, _practicalLesson.TaskCondition, _practicalLesson.Solution);
            training.SetOfObjects = this.SetOfObjects;

            return training;
        }
    }
}
