using Stack;

Stack.Stack<string> stack = new();

stack.Push("one");
stack.Push("two");
stack.Push("three");
stack.Push("four");
stack.Pop();

Console.WriteLine("Stack: ");

foreach (var item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine("Stack reverse: ");


foreach (var item in stack.Reverse())
{
    Console.WriteLine(item);
}

