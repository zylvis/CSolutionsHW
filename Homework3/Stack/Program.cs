// See https://aka.ms/new-console-template for more information

using Stack;

Console.WriteLine("Hello, World!");



Stack.Stack<string> stack = new();

stack.Push("one");
stack.Push("two");
stack.Push("three");
stack.Pop();


foreach (var item in stack)
{
    Console.WriteLine(item);
}



