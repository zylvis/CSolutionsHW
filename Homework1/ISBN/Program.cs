using System;

namespace ISBN
{
    class Program
    {
        //RK: Drop unused var
        static void Main(string[] args)
        {
            Console.Write("Input 9 digit number: ");

            string number = Console.ReadLine();

            //// RK: -->Start
            //StringBuilder strNumber = new StringBuilder();
            //int sum = 0;
            //int count = 10;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    strNumber.Append(number[i]);
            //}

            //int[] numberElements = new int[number.Length];

            //for (int i = 0; i < numberElements.Length; i++)
            //{
            //    numberElements[i] = int.Parse(number[i].ToString());
            //}

            //foreach (var item in numberElements)
            //{
            //    sum += item * count;
            //    count--;
            //}

            //int remainder = sum % 11;
            //int checkDigit = 11 - remainder;
            ////RK:-->End

            //RK: The code between -->Start and -->End lines could be reduced to

            int sum = 0;
            char[] buffer = number.ToCharArray();
            for (int i = 0; i < 9; i++)
            {
                sum += (buffer[i] - '0') * (i + 1);
            }
            int checkDigit = sum % 11;

            //The output code could be reduced to the 2 lines below
            // We have not touched ternar (?) operator and string interpolation here,
            // so this is just for demo.

            string lastChar = checkDigit == 10 ? "X" : checkDigit.ToString();
            Console.WriteLine($"ISBN: {number}{lastChar}");

            //if (checkDigit != 10)
            //{
            //    strNumber.Append(checkDigit.ToString());
            //    Console.Write($"ISBN: {strNumber}");         
            //}
            //else
            //{
            //    strNumber.Append("X");
            //    Console.Write($"ISBN: {strNumber}");
            //}

            Console.WriteLine();
        }
    }
}
