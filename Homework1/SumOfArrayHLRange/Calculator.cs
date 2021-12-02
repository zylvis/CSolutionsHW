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

            //for (int i = 1; i < elements.Length; i++)
            //{
            //    //RK: "elements[i] >= elements[i - 1]" is not required.
            //    if (elements[i] >= elements[i - 1] && elements[i] >= largest)
            //    {
            //        largest = elements[i];
            //        largestIndex = i;
            //    }
            //}

            //for (int i = elements.Length - 1; i > 0; i--)
            //{
            //    //RK: "elements[i] <= elements[i - 1]" is not required.
            //    if (elements[i] <= elements[i - 1] && elements[i] <= smallest)
            //    {
            //        smallest = elements[i];
            //        smallestIndex = i;
            //    }
            //}

            //if (elements[0] >= largest)
            //{
            //    largestIndex = 0;

            //}

            //if (elements[0] <= smallest)
            //{
            //    smallestIndex = 0;
            //}

            //RK: The code above is good enough, but could be simplified a bit
            // and we can get indexes at one cycle 

            int largest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] >= largest)
                {
                    largest = elements[i];
                    largestIndex = i;
                }
                // We put < instead of <= here, because per requirement most left index
                // is required for indexing. 
                if (elements[i] < smallest)
                {
                    smallest = elements[i];
                    smallestIndex = i;
                }
            }
           
            if (smallestIndex > largestIndex)
            {
                //Smart swap, but lets write simpler
                int temp = largestIndex;
                largestIndex = smallestIndex;
                smallestIndex = temp;
                //int swapSum = largestIndex + smallestIndex;
                //largestIndex = swapSum - largestIndex;
                //smallestIndex = swapSum - smallestIndex;
            }

            for (int i = smallestIndex; i <= largestIndex; i++)
            {
                sum += elements[i];
            }

            return sum;
        }
    }
}
