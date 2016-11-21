using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise27
    {
        static void Main (string[] args)
        {
            int x, i, a=0;
            Console.Write(" Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("The positive divisor: ");
            for(i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    a += i;
                    Console.Write("{0} ", i);
                }
            }
            Console.Write("\n The sum of the divisor is: {0}", a);
            if (a == x)
                Console.Write("\nThe number is perfect.");
            else
                Console.Write("\nThe number isn't perfect. ");
            Console.ReadLine();
        }
    }
}
