using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise45
    {
        static void Main(string[] args)
        {
            int m, n, i, j, lcm = 1;

            Console.Write(" Input first number for LCM: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input second number: ");
            n = Convert.ToInt32(Console.ReadLine());

            j = (m > n) ? m : n;
            for (i = j; ; i+=j)
            {
                if (i % m == 0 && i % n == 0)
                {
                    lcm = i;
                    break;
                }
            }             
            Console.Write("The LCM number is: {0}.", lcm);
            Console.ReadLine();
        }
    }
}
