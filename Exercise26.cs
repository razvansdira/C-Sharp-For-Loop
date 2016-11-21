using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise26
    {
        static void Main(string[] args)
        {
            int a, b, c = 0, d = 1;
            Console.Write(" Input the number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=1; b<=a; b++)
            {
                c += d;
                Console.Write("{0} ", d);
                d = d * 10 + 1;
            }
            Console.Write("\n The sum is: {0}",c);
            Console.ReadLine();
        }
    }
}
