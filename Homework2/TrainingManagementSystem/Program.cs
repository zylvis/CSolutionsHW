using TrainingManagementSystem;

namespace TrainingManagementSystem
{
    class Program
    {
        public static void Main()
        {
            var lecture = new Lecture("some lecture description", "Lecture topic");
            var practicalLesson = new PracticalLesson("some practical description", "task", "solution link --->");
            var training = new Training("some training description", lecture, practicalLesson);
            
            Training training2 = training.Clone();

            training.Add(lecture);
            training.Add(practicalLesson);

            foreach (var item in training.SetOfObjects)
            {
                if (item is Lecture)
                {
                    Lecture temp = (Lecture)item;
                    Console.WriteLine(temp.Topic);
                }
                if (item is PracticalLesson)
                {
                    PracticalLesson temp = (PracticalLesson)item;
                    Console.WriteLine(temp.Solution);
                }
            }

            Console.WriteLine(training.IsPractical());

            Console.WriteLine(training2.DescriptionText);

            foreach (var item in training2.SetOfObjects)
            {
                if (item is Lecture)
                {
                    Lecture temp = (Lecture)item;
                    Console.WriteLine(temp.Topic);
                }
                if (item is PracticalLesson)
                {
                    PracticalLesson temp = (PracticalLesson)item;
                    Console.WriteLine(temp.Solution);
                }
            }
        }
    }
}
