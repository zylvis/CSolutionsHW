
using Task1;
using Tracking;



TestClass testClass = new TestClass();
testClass.Age = 20;
testClass.FirstName = "John";
testClass.LastName = "Black";
testClass.Email = "email@mail";

Logger logger = new Logger("TestClass");

logger.Track(testClass);


Type tp = typeof(TestClass);

// 2. Get a list of the attributes that are attached to the class MyClass
object[] attr = tp.GetCustomAttributes(false);

// 3. Print the names of the attributes attached to MyClass
Console.WriteLine("Attributes of class MyClass:");
foreach (var item in attr)
{
    if (item is TrackingEntityAttribute)
    {
        Console.WriteLine(item.GetType().Name);
    }

}
Console.ReadKey();