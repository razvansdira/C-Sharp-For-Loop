using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise54
    {
        public static void Main(string[] args)
        {
            int n, m, p = 1, k = 0;
            int dec = 0, i = 1, j, l;

            Console.Write(" Input an octal number(0 - 7): ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            for (j = n; j > 0; j = j / 10)
            {
                l = j % 10;
                if (i == 1)
                    p *= 1;
                else
                    p *= 8;

                dec += (l * p);
                i++;
            }
            i = 1;

            for (j = dec; j > 0; j /= 2)
            {
                k += (dec % 2) * i;
                i *= 10;
                dec /= 2;
            }
            Console.Write("   The binary number: {0}.", k);
            Console.ReadLine();
        }  
    }
}
