using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary2s
{
    //RK: add "internal" before "class" method, it is a good practice
    // to explicitly set protection modifiers.
    class Converter
    {
        public string DecimalToTernary(int n)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder strTernary = new StringBuilder();

            while (n != 0)
            {
                str.Append(n % 3);
                n /= 3;
            }

            // RK: The transforms below could be replaced with that call
            // return str.ToString().Reverse().ToString();
            //
            // Yeah, this is not "fair" as we have not discussed Linq
            // yet, but anyway it is simpler. 


            char[] charArray = str.ToString().ToCharArray();
            Array.Reverse(charArray);

            for (int i = 0; i < charArray.Length; i++)
            {
                strTernary.Append(charArray[i]);
            }

            return strTernary.ToString();
        }
    }
}
