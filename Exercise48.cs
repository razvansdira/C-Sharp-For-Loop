using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise48
    {
        static void Main(String[] args)
        {
            int i, j, r, s, q, t, x, y;

            Console.Write(" Input starting range of strong number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input ending range of strong number: ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("The strong numbers are : ");

            for (r = x; r <= q; r++)
            {
                y = r;
                s = 0;

                for (j = r; j > 0; j /= 10)
                {

                    t = 1;
                    for (i = 1; i <= j % 10; i++)
                    {
                        t *= i;
                    }
                    s += t;
                }
                if (s == y)
                    Console.Write("{0}  ", y);
            }
            Console.ReadLine();
        }
    }
}
