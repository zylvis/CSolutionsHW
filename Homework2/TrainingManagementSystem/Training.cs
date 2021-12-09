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

        public IEnumerable<Lecture> Lectures { get; set; }

        public IEnumerable<PracticalLesson> PracticalLessons { get; set; }

        public void Add(Lecture lecture)
        {
            Lectures.Append(lecture);

        }

    }
}
