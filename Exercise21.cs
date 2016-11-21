using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise21
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, d = 9;
            Console.Write(" Input the number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=1; b<=a; b++)
            {
                c += d;
                Console.Write("{0} ", d);
                d = d * 10 + 9;
            }
            Console.Write("\n The sum of the series is: {0}",c);
            Console.ReadLine();
        }
    }
}
