using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace Stack
{
    public static class Extentions
    {
        public static Stack<T> ReverseStack<T>(this IStack<T> stack)
        {
            Stack<T> reverseStack = new Stack<T>(stack.MaxSize);
            while (!stack.IsEmpty())
            {
                reverseStack.Push(stack.Pop());
            }

            return reverseStack;
        }
    }
}
