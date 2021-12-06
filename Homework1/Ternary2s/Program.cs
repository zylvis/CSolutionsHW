using System;


namespace Ternary2s
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter int b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Converter converter = new Converter();
            
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (; a <= b; a++)
            {
                string ternar = converter.DecimalToTernary(a);
                int count = 0;
                foreach (char c in ternar)
                {
                    if (c is '2')
                    {
                        count++;
                    }
                }

                if (count is 2)
                {
                    Console.WriteLine(ternar);
                }
            }
        }
    }
}
