using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise49
    {
        public static void Main(String[] args)
        {
            int m, n, df, i, ln, s;

            Console.Write("    Input  the starting number of the AP series: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("   Input the number of items for  the AP series: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Input  the common difference of AP series: ");
            df = Convert.ToInt32(Console.ReadLine());

            s = (n * (2 * m + (n - 1) * df)) / 2;
            ln = m + (n - 1) * df;
            Console.Write(" The sum of the  AP series is: \n");

            for (i = m; i <= ln; i = i + df)
            {
                if (i != ln)
                    Console.Write("{0} + ", i);
                else
                    Console.Write("{0} = {1} ", i, s);
            }
            Console.ReadLine();
        }
    }
}
