using System;

namespace ISBN
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input 9 digit number: ");

            string number = Console.ReadLine();

            int sum = 0;
            char[] buffer = number.ToCharArray();
            for (int i = 0; i < 9; i++)
            {
                sum += (buffer[i] - '0') * (i + 1);
            }
            int checkDigit = sum % 11;

            string lastChar = checkDigit == 10 ? "X" : checkDigit.ToString();
            Console.WriteLine($"ISBN: {number}{lastChar}");
            
            Console.WriteLine();
        }
    }
}
