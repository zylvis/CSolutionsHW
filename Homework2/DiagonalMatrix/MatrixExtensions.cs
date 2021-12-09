using System;
using System.Collections.Generic;
using System.Text;

namespace DiagonalMatrix
{
    public static class MatrixExtensions
    {
        public static int[] AddMatrix(this Matrix a, Matrix b)
        {
           

            if (a.Size < b.Size)
            {
                Matrix temp = a;
                a = b;
                b = temp;
            }
            int[] result = new int[a.Size];

            for (int i = 0; i < a.Size; i++)
            {
                if (i < b.Size)
                {
                    result[i] = a.DiagonalElements[i] + b.DiagonalElements[i];
                }
                if (i >= b.Size)  
                {
                    result[i] = a.DiagonalElements[i] + 0;
                }
            }



            return result;
        }
    }
}
