using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public interface IStack<T>
    {
        int MaxSize { get; }
        void Push(T value);
        T Pop();
        bool IsEmpty();
    }
}
