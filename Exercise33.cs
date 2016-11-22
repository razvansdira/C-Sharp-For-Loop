using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise33
    {
        static void Main(string[] args)
        {
            int x, y, z = 1, i, j;

            Console.Write(" Input a number of rows: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < x; i++)
            {
                for (y = 1; y <= x - i; y++)
                    Console.Write("  ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        z = 1;
                    else
                        z = z * (i - j + 1) / j;
                    Console.Write("{0}   ", z);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
