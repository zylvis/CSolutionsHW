using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrixT
{
    public class MatrixEventArgs<T> : EventArgs
    {
        public int Index { get; set; }
        public T? NewValue { get; set; }
        public T? OldValue { get; set; }
    }
}
