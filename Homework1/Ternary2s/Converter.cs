using System;
using System.Text;

namespace Ternary2s
{
    internal class Converter
    {
        public string DecimalToTernary(int n)
        {
            StringBuilder str = new StringBuilder();
            
            while (n != 0)
            {
                str.Append(n % 3);
                n /= 3;
            }

            char[] charArray = str.ToString().ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
