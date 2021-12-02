using System;
using System.Collections.Generic;

namespace Ternary2s
{
    class Program
    {
        //RK: args is not used and could be dropped. 
        static void Main(string[] args)
        {
            Console.Write("enter int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter int b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Converter converter = new Converter();
            List<string> rangeTernaryItems = new List<string>();


            // RK: This is a smart way for swap, but prefferably
            // would be to use standard code:
            // int temp = a; a = b; b = temp;
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
                //int c = a + b;
                //a = c - a;
                //b = c - b;
            }

            for (; a <= b; a++)
            {
                string ternar = converter.DecimalToTernary(a);
                int count = 0;
                foreach (char c in ternar)
                {
                    if (c == '2')
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine(ternar);
                }
            }
        }
    }
}
