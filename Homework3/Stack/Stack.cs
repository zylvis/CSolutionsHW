using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IStack<T>, IEnumerable<T>
    {
        private int top;
        private T[] Items { get; set; }
        public int MaxSize { get; set; }

        public Stack(int maxSize)
        {
            MaxSize = maxSize;
            Items = new T[MaxSize];
            top = -1;
        }
        public void Push(T value)
        {
            if (top >= MaxSize)
            {
                throw new ArgumentOutOfRangeException("Stack riched maxSize limit");
            }
            else 
            {
                Items[++top] = value;
            }
            
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }
                        
            return Items[top--];
        }
               

        public bool IsEmpty()
        {
            return top < 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top; i >= 0; i--)
            {
                yield return  Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
