using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(2, 9, 45);
            Matrix m2 = new Matrix();

            Console.Write($"\"m\" elements:");
            foreach (var item in m.Elements)
            {
                Console.Write($"*{item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Size: {m.Size}");
            Console.WriteLine($"Sum: {m.Track()}");

            Console.Write($"\"m2\" elements:");
            foreach (var item in m2.Elements)
            {
                Console.Write($"*{item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Size: {m2.Size}");
            Console.WriteLine($"Sum: {m2.Track()}");


        }
    }
}
