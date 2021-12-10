using TrainingManagementSystem;

var lecture = new Lecture("", "topic");
var practicalLesson = new PracticalLesson();
var training = new Training("", lecture, practicalLesson);

training.Add();

foreach (var item in training.Lectures)
{
    Console.WriteLine($"{item.DescriptionText} -- {item.Topic}");
}


