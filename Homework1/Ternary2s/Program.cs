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
                int c = a + b;
                a = c - a;
                b = c - b;
            }

            for (; a <= b; a++)
            {
                //RK: Search of "2"s could be simplified with
                // string ternar = converter.DecimalToTernary(a);
                // foreach(char c in ternar) ...
                // 
                //So, we do not need in ToCharArray call and j variable
                char[] ternaryItem = converter.DecimalToTernary(a).ToCharArray();

                int count = 0;
                for (int j = 0; j < ternaryItem.Length; j++)
                {
                    if (ternaryItem[j] == '2')
                    {
                        count++;
                    }
                }

                //RK: There is no need to store result in rangeTernaryItems
                // result could be printed immedeately as Console.WriteLine(ternar);
                // Also, converter.DecimalToTernary is called twice,
                // keep result in buffer variable to avoid extra computations.
                if (count == 2)
                {
                    rangeTernaryItems.Add(converter.DecimalToTernary(a));
                }

            }

            // RK: Just print result immedeately
            for (int i = 0; i < rangeTernaryItems.Count; i++)
            {
                Console.WriteLine(rangeTernaryItems[i]);
            }
        }
    }
}
