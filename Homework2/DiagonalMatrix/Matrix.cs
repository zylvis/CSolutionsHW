using System;
using System.Collections.Generic;
using System.Text;

namespace DiagonalMatrix
{
    public class Matrix
    {
        private int[] elements;
        private readonly int size;
                      
        public Matrix(params int[] elements)
        {
            this.elements = elements;
            size = elements.Length;
        }
        public int[] Elements => elements;
        public int Size => size;

        public int Track()
        {
            int sum = 0;
            foreach (var item in Elements)
            {
                sum += item;
            }
            return sum;
        }
        
    }
        
}
