using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagonalMatrixT;

namespace DiagonalMatrixT
{
    public static class MatrixExtensions
    {
        public static Matrix<T> Add<T>(this Matrix<T> a, Matrix<T> b, Func<Matrix<T>, Matrix<T>, Matrix<T>> Addition)
        {
            return Addition(a, b);    
        }       
    }
}
