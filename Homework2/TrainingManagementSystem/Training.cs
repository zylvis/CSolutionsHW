using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class Training
    {
        private string _descriptionText;
        private Lecture _lecture;
        private PracticalLesson _practicalLesson;
        public Training(string description, Lecture lecture, PracticalLesson practicalLesson)
        {
            _descriptionText = description;
            _lecture = lecture;
            _practicalLesson = practicalLesson;
        }
        public string? DescriptionText { get; set; }

        public Dictionary<Lecture, PracticalLesson> SetOfObjects { get; set; } = new Dictionary<Lecture, PracticalLesson>();

        public Dictionary<Lecture, PracticalLesson> Add()
        {
            if (_lecture != null)
            {
                SetOfObjects.Add(_lecture, _practicalLesson);
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
            Training training = new(this._descriptionText,
                               _lecture, _practicalLesson);
            return training;
        }
    }
}
