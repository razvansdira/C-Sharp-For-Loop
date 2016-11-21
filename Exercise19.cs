using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise19
    {
        static void Main(string[] args)
        {
            int a, b;
            double c=0.0;

            Console.Write(" Input a number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 1; b <= a; b++)
            {
                Console.Write("1/{0} + ", b);
                c += 1 / (float)b;
            }
            Console.Write("\n Sum of series upto {0} terms is: {1}", a, c);
            Console.ReadLine();
        }
    }
}
