using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise53
    {
        public static void Main(String[] args)
        {
            int m, n, p = 1, k = 0;
            int dec = 0, i = 1, j, l;

            Console.Write(" Input a binary number: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            for (j = n; j > 0; j = j / 10)
            {
                l = j % 10;
                if (i == 1)
                    p *= 1;
                else
                    p *= 2;
                dec += (l * p);
                i++;
            }
            i = 1;

            for (j = dec; j > 0; j /= 8)
            {
                k +=(j % 8) * i;
                i *= 10;
                n /= 8;
            }
            Console.Write("The octal number is: {0}.", k);
            Console.ReadLine();
        }  
    }
}
