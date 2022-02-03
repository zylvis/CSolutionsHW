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
        public static Matrix<T> Add<T>(this Matrix<T> a, Matrix<T> b, Func< T, T, T> Addition)
        {
            Matrix<T> matrix = new Matrix<T>(a.Size);
            for (int i = 0; i < a.Size; i++)
            {
                matrix[i, i] = Addition(a[i, i], b[i, i]);
            }
            return matrix;  
        }        
    }
}
