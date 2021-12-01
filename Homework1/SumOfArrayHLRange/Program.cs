using System;

namespace SumOfArrayHLRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter lenght of array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] elements = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element No.({i + 1}): ");
                elements[i] = int.Parse(Console.ReadLine());
            }

            int sum = calculator.RangeElementsSum(elements);

            Console.Write("Elements: [ ");
            foreach (var item in elements)
            {
                Console.Write($"{item} ");
            }
            Console.Write("]");

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
