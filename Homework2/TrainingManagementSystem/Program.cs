using TrainingManagementSystem;

namespace DiagonalMatrix
{
    class Program
    {
        public static void Main()
        {
            var lecture = new Lecture(string.Empty, "topic");
            var practicalLesson = new PracticalLesson("some description", "task", "solution link --->");
            var training = new Training(string.Empty, lecture, practicalLesson);

            foreach (var item in training.Add())
            {
                Console.WriteLine($"{item.Key.Topic} - {item.Key.DescriptionText} : {item.Value.TaskCondition} - {item.Value.Solution} - {item.Value.DescriptionText}");
            }

            Console.WriteLine(training.IsPractical());

            Training training2 = training.Clone();

            foreach (var item in training2.Add())
            {
                Console.WriteLine($"{item.Key.Topic} - {item.Key.DescriptionText} : {item.Value.TaskCondition} - {item.Value.Solution} - {item.Value.DescriptionText}");
            }
        }
    }
}
