using TrainingManagementSystem;

namespace DiagonalMatrix
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
                    Lecture o = (Lecture)item;
                    Console.WriteLine(o.Topic);
                }
                if (item is PracticalLesson)
                {
                    PracticalLesson o = (PracticalLesson)item;
                    Console.WriteLine(o.Solution);
                }
            }

            Console.WriteLine(training.IsPractical());

            Console.WriteLine(training2.DescriptionText);
        }
    }
}
