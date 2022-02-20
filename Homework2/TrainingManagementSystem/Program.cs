using TrainingManagementSystem;

namespace TrainingManagementSystem
{
    class Program
    {
        public static void Main()
        {
            var lecture = new Lecture("some lecture description", "Lecture topic");
            var practicalLesson = new PracticalLesson("some practical description", "task", "solution link --->");
            var training = new Training("some training description");

            training.Add(lecture);
            training.Add(practicalLesson);

            foreach (var item in training.SetOfObjects)
            {
                if (item is Lecture)
                {
                    Lecture temp = (Lecture)item;
                    Console.WriteLine(temp.DescriptionText + ", " + temp.Topic);
                }
                if (item is PracticalLesson)
                {
                    PracticalLesson temp = (PracticalLesson)item;
                    Console.WriteLine(temp.DescriptionText + ", " + temp.TaskCondition + ", " + temp.Solution);
                }
            }

            Console.WriteLine(training.IsPractical());


            Console.WriteLine("Cloned items: ");

            Training training2 = training.Clone();

            foreach (var item in training2.SetOfObjects)
            {
                if (item is Lecture)
                {
                    Lecture temp = (Lecture)item;
                    Console.WriteLine(temp.DescriptionText + ", " + temp.Topic);
                }
                if (item is PracticalLesson)
                {
                    PracticalLesson temp = (PracticalLesson)item;
                    Console.WriteLine(temp.DescriptionText + ", " + temp.TaskCondition + ", " + temp.Solution);
                }
            }
        }
    }
}
