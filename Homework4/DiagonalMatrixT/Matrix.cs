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
    public class Matrix<T>
    {        
        public event EventHandler<MatrixEventArgs<T>> ElementChanged;

        public int Size
        {
            get; set;
        }

        public T? OldValue { get; set; }
        public T[] DiagonalElements { get; set; }

        public Matrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Matrix size cant be less than 0");
            }

            Size = size;

            DiagonalElements = new T[Size];
        }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new ArgumentException("Out of range SquareMatrix indexes");
                }
                else if (i == j)
                {
                    return DiagonalElements[i];
                }
                else
                {
                    return default(T);
                }
            }
        }
        public override string ToString()
        {
            return String.Join(",", DiagonalElements);
        }

        public void UpdateMatrix(int index, T newValue, Func<int, T, bool> action)
        {
            if (action(index, newValue))
            {
                OldValue = DiagonalElements[index];
                DiagonalElements[index] = newValue;

                OnElementChanged(index, newValue);
            }
        }

        protected virtual void OnElementChanged(int index, T newValue)
        {
            ElementChanged.Invoke(this, new MatrixEventArgs<T>() { Index = index, NewValue = newValue, OldValue = OldValue });
        }

    }
}
