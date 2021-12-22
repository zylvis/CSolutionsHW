using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Training
    {
        private Description _description;
        private Lecture _lecture;
        private PracticalLesson _practicalLesson;
        public Training(Description description, Lecture lecture, PracticalLesson practicalLesson)
        {
            _description = description;
            _lecture = lecture;
            _practicalLesson = practicalLesson;
        }
        public string? DescriptionText { get; set; }

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
            Training training = new(this._description,
                               _lecture, _practicalLesson);
            return training;
        }
    }
}
