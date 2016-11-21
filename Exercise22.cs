using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise22
    {
        static void Main(string[] args)
        {
            int i, j, k, l, m;
            Console.Write(" Input a number: ");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= k; i++)
            {
                if (i % 2 == 0)
                {
                    l = 1; m = 0;
                }
                else
                {
                    l = 0; m = 1;
                }
                for (j = 1; j <= i; j++)
                    if (j % 2 == 0)
                        Console.Write("{0} ", l);
                    else
                    Console.Write("{0} ", m);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
