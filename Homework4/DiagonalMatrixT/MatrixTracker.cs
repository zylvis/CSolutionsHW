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
        public T? OldValue { get; set; }

        public Matrix<T> Matrix { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            Matrix = matrix;
            Matrix.ElementChanged += OnElementChanged;
        }
        
        public void OnElementChanged(object source, MatrixEventArgs<T> args)
        {
            Console.WriteLine($"Update happened: Index - {args.Index} NewValue - {args.NewValue} + OldValue{args.OldValue}"); // testing
            OldValue = args.OldValue;
            oldIndex = args.Index;
        }

        public Matrix<T> Undo()
        {
            Matrix[oldIndex, oldIndex] = OldValue;
            return Matrix;
        }
    }
}
