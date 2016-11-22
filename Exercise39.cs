using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise39
    {
        static void Main(string[] args)
        {
            int a, sum = 0;

            Console.WriteLine("  Numbers between 100 and 200, divisible by 9:");
            for (a = 100; a <= 200; a++)
            {
                if (a % 9 == 0)
                {
                    Console.Write("{0}  ", a);
                    sum += a;
                }
            }
            Console.Write("\n  The sum is: {0} ", sum);
            Console.ReadLine();
        }
    }
}
