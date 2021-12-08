using System;
using System.Collections.Generic;
using System.Text;

namespace DiagonalMatrix
{
    public class Matrix
    {
        private readonly int[] _diagonalElements;
        private readonly int _size;

        public Matrix(params int[] elements)
        {
            _diagonalElements = elements;
            _size = elements.Length;
        }


        public int[] DiagonalElements => _diagonalElements;
        public int Size => _size;

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 && j < 0 || i >= Size || j >= Size)
                {
                    throw new Exception("Out of range SquareMatrix indexes ");
                }
                else if (i == j)
                {
                    return DiagonalElements[i];
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach (var item in DiagonalElements)
            {
                sum += item;
            }
            return sum;
        }
    }
}
