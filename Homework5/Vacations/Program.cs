using Vacations;

var object1 = new Employee("John", new DateTime(2021, 1, 19), new DateTime(2021, 2, 22));
var object2 = new Employee("Steve", new DateTime(2021, 3, 6), new DateTime(2021, 3, 8));
var object3 = new Employee("John", new DateTime(2021, 12, 3), new DateTime(2021, 12, 31));

Vacation vacation = new Vacation();
vacation.Add(object1);
vacation.Add(object2);
vacation.Add(object3);

Console.WriteLine("Average days of vacations: " + vacation.GetAverageDaysOfVacations());

Console.WriteLine("Average days of Each Employee: ");
foreach (var item in vacation.GetAveregeDaysOfVacationsEach())
{
    Console.WriteLine($"{item.name} : {item.averageDays}");
}

Console.WriteLine("Number of Emploees took vacation by month: ");
foreach (var item in vacation.GetMonthsWithEmployess())
{
    Console.WriteLine($"Month: {item.month} - Number of people: {item.empCount}");
}


Console.WriteLine("Free dates: ");

foreach (var item in vacation.GetFreeDates())
{
    Console.WriteLine(item);
}