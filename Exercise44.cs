using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise44
    {
        static void Main(string[] args)
        {
            int m, n, i, j, hcf = 1, lcm;

            Console.Write(" Input first number for LCM: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input second number: ");
            n = Convert.ToInt32(Console.ReadLine());

            j = (m < n) ? m : n;
            for (i = 1; i <= j; i++)
            {
                if (m % i == 0 && n % i == 0)
                    hcf = i;
            }
            lcm = (m * n) / hcf;

            Console.Write("The LCM number is: {0}.", lcm);
            Console.ReadLine();
        }
    }
}
