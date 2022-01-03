// See https://aka.ms/new-console-template for more information

using Stack;

Console.WriteLine("Hello, World!");



Stack.Stack<string> stack = new();

stack.Push("bybis");
stack.Push("byraj");



for (int i = 0; i < 2; i++)
{
    Console.WriteLine(stack[i]);
}



