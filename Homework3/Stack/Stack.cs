using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IStack<T>, IEnumerable
    {
        private T[] Items { get; set; } = new T[0];
        public int Size { get; private set; }
        public int MaxSize { get; set; }

        public Stack(int maxSize)
        {
            MaxSize = maxSize;
        }
        public void Push(T value)
        {
            if (Size == MaxSize)
            {
                throw new ArgumentOutOfRangeException("Stack riched maxSize limit");
            }
            else if( Size == Items.Length)
            {
                int newlength = Size == 0 ? 1 : Size + 1;
                T[] newarray = new T[newlength];
                Items.CopyTo(newarray, 0);
                Items = newarray;
            }
            Items[Size] = value;
            Size++;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            Size--;
            return Items[Size];
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}
