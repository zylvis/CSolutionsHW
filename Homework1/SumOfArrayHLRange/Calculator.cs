using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfArrayHLRange
{
    internal class Calculator
    {
        public int RangeElementsSum(int[] elements)
        {
            int largestIndex = 0;
            int smallestIndex = 0;
            int sum = 0;

            int largest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] >= largest)
                {
                    largest = elements[i];
                    largestIndex = i;
                }

                if (elements[i] < smallest)
                {
                    smallest = elements[i];
                    smallestIndex = i;
                }
            }
           
            if (smallestIndex > largestIndex)
            {
                int temp = largestIndex;
                largestIndex = smallestIndex;
                smallestIndex = temp;               
            }

            for (int i = smallestIndex; i <= largestIndex; i++)
            {
                sum += elements[i];
            }

            return sum;
        }
    }
}
