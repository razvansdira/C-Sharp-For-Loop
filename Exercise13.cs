using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            int i, j, n, k, m, l = 1;

            Console.Write(" Input a number : ");
            k = Convert.ToInt32(Console.ReadLine());
            n = k + 4 - 1;

            for (i = 1; i <= k; i++)
            {
                for (m = n; m >= 1; m--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", l++);
                Console.Write("\n");
                n--;
            }
            Console.ReadLine();
        }
    }
}
