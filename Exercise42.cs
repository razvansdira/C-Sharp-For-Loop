using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise42
    {
        static void Main(string[] args)
        {
            int x, i = 1, j, r, s, p=1, dec=0;
            Console.Write(" Input a binary number to convert: ");
            x = Convert.ToInt32(Console.ReadLine());
            r = x;

            for (j = x; j > 0; j /= 10)
            {
                s = j % 10;
                if (i == 1)
                    p *= 1;
                else
                    p *= 2;
                dec += (s * p);
                i++;
            }
            Console.Write("The decimal number is: {0}.", dec);
            Console.ReadLine();
        }
    }
}
