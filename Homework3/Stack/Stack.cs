using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack<T> : IStack<T>
    {
        T[] items = new T[0];
        int size;

        
        public void Push(T value)
        {
            if (size == items.Count())
            {
                int newlength = size == 0 ? 1 : size +1;
                T[] newarray = new T[newlength]; // array with new size   
                items.CopyTo(newarray, 0);
                items = newarray;
            }
            items[size] = value;
            size++;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            size--;
            return items[size];
        }

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

    }
}
