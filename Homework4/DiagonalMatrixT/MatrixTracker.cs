﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrixT
{
    public class MatrixTracker<T>
    {
        private int oldIndex;
        public Matrix<T> Matrix { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            Matrix = matrix;
        }

        public void OnElementChanged(object source, MatrixEventArgs<T> args)
        {           
            Console.WriteLine("Update happened" + args.Index + args.NewValue + "  " + args.OldValue);
            oldIndex = args.Index;
        }
        public Matrix<T> Undo()
        {

            Matrix.DiagonalElements[oldIndex] = Matrix.OldValue;
            return Matrix;

           
        }
    }
}
