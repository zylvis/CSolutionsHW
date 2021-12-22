using TrainingManagementSystem;

namespace DiagonalMatrix
{
    class Program
    {
        public static void Main()
        {
            var lecture = new Lecture("some lecture description", "topic");
            var practicalLesson = new PracticalLesson("some practical description", "task", "solution link --->");
            var training = new Training("some trainingl description", lecture, practicalLesson);

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
