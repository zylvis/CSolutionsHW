using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace Stack
{
    public static class Extensions
    {
        public static Stack<T> Reverse<T>(this Stack.Stack<T> stack)
        {            
            stack.items.Reverse();
            var reverseStack = stack;
            return reverseStack;
        }

        
    }
}
