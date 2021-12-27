using TrainingManagementSystem;

namespace DiagonalMatrix
{
    class Program
    {
        public static void Main()
        {
            var lecture = new Lecture("Lecture topic");
            var practicalLesson = new PracticalLesson("task", "solution link --->");
            var training = new Training(lecture, practicalLesson, "some lecture description", "some practical description", "some training description");
                        
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

            Console.WriteLine(training2.LectureDescription);
        }
    }
}
