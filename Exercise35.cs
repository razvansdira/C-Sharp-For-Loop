using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise35
    {
        static void Main(string[] args)
        {
            int a, b, c=0, d=1, e;

            Console.Write(" Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("The fibonacci series is: {0} {1} ", c, d);

            for (b=3;b<=a;b++)
            {
                e = c + d;
                c = d;
                d = e;
                Console.Write("{0} ", e);
            }
            Console.ReadLine();
        }
    }
}
