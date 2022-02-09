
using Task1;
using Tracking;


TestClass testClass = new TestClass();
testClass._number = 1;
testClass.Age = 20;
testClass.FirstName = "John";
testClass.LastName = "Black";
testClass.Email = "email@mail";

Logger logger = new("TestClass");

logger.Track(testClass);


