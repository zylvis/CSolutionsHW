using System;
using System.Collections.Generic;
using System.Text;

namespace DiagonalMatrix
{
    public class Matrix
    {
        private readonly int size;
              
        public Matrix(params int[] elements)
        {
            size = elements.Length;
        }
        public int Size => size;
    }
        
}
