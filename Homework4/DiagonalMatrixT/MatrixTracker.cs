using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrixT
{
    public class MatrixTracker<T>
    {
        private int oldIndex;
        private T? OldValue { get; set; }
        private MatrixEventArgs<T> eventArgs;
        private Matrix<T> Matrix { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            Matrix = matrix;
            Matrix.ElementChanged += OnElementChanged;
        }

        public void OnElementChanged(object source, MatrixEventArgs<T> args)
        {
            Console.WriteLine($"Update happened: Index - {args.Index} NewValue - {args.NewValue} + OldValue - {args.OldValue}"); // testing
            OldValue = args.OldValue;
            oldIndex = args.Index;
            eventArgs = args;
        }

        public Matrix<T> Undo()
        {
            if (eventArgs == null)
            {
                return Matrix;
            }
            else
            {
                Matrix[oldIndex, oldIndex] = OldValue;
                return Matrix;
            }
        }
    }
}
