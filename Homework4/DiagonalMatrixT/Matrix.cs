using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrixT
{

    public class Matrix<T> : IEnumerable<T>
    {
        public event EventHandler<MatrixEventArgs<T>> ElementChanged;

        public int Size
        {
            get; private set;
        }
        public T? OldValue { get; set; }
        private T[] DiagonalElements { get; set; }

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
            set
            {
                if (i == j)
                {
                    if (!DiagonalElements[i].Equals(value))
                    {
                        OldValue = DiagonalElements[i];
                        OnElementChanged(i, value);
                        DiagonalElements[i] = value;
                      
                    }
                }
            }
        }

        public override string ToString()
        {
            return String.Join(",", DiagonalElements);
        }

        protected virtual void OnElementChanged(int index, T newValue)
        {
            ElementChanged?.Invoke(this, new MatrixEventArgs<T>() { Index = index, NewValue = newValue, OldValue = OldValue });
        }

        public IEnumerator<T> GetEnumerator()
        {
            return DiagonalElements.ToList().GetEnumerator(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
} 
