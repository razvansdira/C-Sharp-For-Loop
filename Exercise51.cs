using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise51
    {
        public static void Main()
        {
            int n, m, p = 1, k, ch = 1;
            int dec = 0, i = 1, j, l;

            Console.Write(" Input an octal number(0 - 7): ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            for (; n > 0; n = n / 10)
            {
                k = n % 10;
                if (k >= 8)
                    ch = 0;
            }
            switch (ch)
            {
                case 0:
                    Console.Write("The number is not an octal number.");
                    break;
                case 1:
                    n = m;
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
                    Console.Write("The equivalent decimal number: {0}", dec);
                    break;
            }
            Console.ReadLine();
        }
    }
}
