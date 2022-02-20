using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    public class Training : Description
    {
        private const int MAX_SET_NUMBER = 4;
        private int _existingSetElements;
        public Training(string descriptionText)
            : base(descriptionText)
        {
            _existingSetElements = 0;
        }

        public Description[] SetOfObjects { get; set; } = new Description[MAX_SET_NUMBER];

        public void Add(Description description)
        {
            if (_existingSetElements < MAX_SET_NUMBER)
            {
                if (description is Lecture)
                {
                    SetOfObjects[_existingSetElements] = description;
                    _existingSetElements++;

                }
                else if (description is PracticalLesson)
                {
                    SetOfObjects[_existingSetElements] = description;
                    _existingSetElements++;
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

        public override Training Clone()
        {

            Training clone = new Training(this.DescriptionText);

            if (_existingSetElements != 0)
            {
                for (int i = 0; i <= _existingSetElements; i++)
                {
                    if (SetOfObjects[i] is PracticalLesson || SetOfObjects[i] is Lecture)
                    {
                        clone.SetOfObjects[i] = SetOfObjects[i].Clone();
                    }
                }
            }
            return clone;
        }


    }
}

