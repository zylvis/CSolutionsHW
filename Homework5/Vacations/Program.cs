using Vacations;

var object1 = new Employee("John", new DateTime(2021, 1, 19), new DateTime(2021, 2, 22));
var object2 = new Employee("Steve", new DateTime(2021, 3, 6), new DateTime(2021, 3, 29));
var object3 = new Employee("John", new DateTime(2021, 12, 3), new DateTime(2021, 12, 31));
var object4 = new Employee("Steve", new DateTime(2021, 4, 3), new DateTime(2021, 9, 3));
var object5 = new Employee("Jack", new DateTime(2021, 10, 3), new DateTime(2021, 11, 30));
var object6 = new Employee("Osburn", new DateTime(2021, 11, 4), new DateTime(2021, 11, 30));
var object7 = new Employee("Osburn", new DateTime(2021, 11, 4), new DateTime(2021, 11, 30));

Vacation vacation = new Vacation();
vacation.Add(object1);
vacation.Add(object2);
vacation.Add(object3);
vacation.Add(object4);
vacation.Add(object5);
vacation.Add(object6);
vacation.Add(object7);

Console.WriteLine("Average days of vacations: " + vacation.GetAverageDaysOfVacations());

Console.WriteLine("Average days of Each Employee: ");
foreach (var item in vacation.GetAveregeDaysOfVacationsEach())
{
    Console.WriteLine($"{item.name} : {item.averageDays}");
}

Console.WriteLine("Number of Emploees took vacation by month: ");
foreach (var item in vacation.GetNumberEachMonth())
{
    Console.WriteLine($"Month: {item.month} - Number of people: {item.empCount}");
}

Console.WriteLine("Free dates: ");

foreach (var item in vacation.GetFreeDates())
{
    Console.WriteLine(item);
}

Console.WriteLine("Dates Intersect: ");
Console.WriteLine(vacation.PersonDatesIntersect());


