using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix(2, 9, 45);
            Matrix matrix2 = new Matrix(2, 9, 45, 63);

            Console.Write($"\"m\" elements:");
            foreach (var item in matrix.DiagonalElements)
            {
                Console.Write($"*{item}");
            }


            Console.WriteLine();
            Console.WriteLine($"Size: {matrix.Size}");
            Console.WriteLine($"Sum: {matrix.Track()}");

            Console.Write($"\"m2\" elements:");
            foreach (var item in matrix2.DiagonalElements)
            {
                Console.Write($"*{item}");
            }
            Console.WriteLine();
            Console.WriteLine($"Size: {matrix2.Size}");
            Console.WriteLine($"Sum: {matrix2.Track()}");

            Console.WriteLine($"Indexer: {matrix[2, 2]}");

            Console.WriteLine(matrix.Equals(matrix2));

            Console.WriteLine(matrix2.ToString());

            Console.WriteLine(String.Join(",", matrix.AddMatrix(matrix2)));

        }
    }
}