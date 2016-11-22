using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise28
    {
        static void Main (string[] args)
        {
            int x, y, i, j, k;

            Console.Write("Input the starting range of number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number: ");
            y = Convert.ToInt32(Console.ReadLine());

            for(i=x; i<=y; i++)
            {
                j = 1;
                k = 0;
                while(j<i)
                {
                    if (i % j == 0)
                        k += j;
                    j++;
                }
                if (k == i)
                    Console.Write(" {0} ", i);
            }
            Console.ReadLine();
        }
    }
}
