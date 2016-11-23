using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise52
    {
        public static void Main()
        {
            int x, y, z, n;
            double sum = 0, tn, gpn;

            Console.Write(" Input the first number of the GP series: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number or terms in the GP series: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the common ratio of GP series: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("The numbers for the GP series: ");
            Console.Write("1  ");

            for (z = 1; z <= n; z++)
            {
                gpn = Math.Pow(y, z);
                Console.Write("{0}  ", gpn);
            }
            sum = (x * (1 - (Math.Pow(y, n + 1)))) / (1 - y);
            tn = x * (Math.Pow(y, n - 1));

            Console.Write("\n The tn terms of GP: {0} ", tn);
            Console.Write("\nThe sum of the GP series: {0} ", sum);
            Console.ReadLine();
        }  
    }
}
