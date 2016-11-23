using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise56
    {
        static void Main(string[] args)
        {
            int a, b, c, d=1, e=1, f=0;
            Console.Write(" Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=3; b<=a/2; b++)
            {
                d = 1;
                e = 1;
                for(c=2; c<b; c++)
                {
                    if (b % c == 0)
                    {
                        d = 0;
                        c = b;
                    }
                }
                for(c=2; c<a-b; c++)
                {
                    if ((a-b) % c == 0)
                    {
                        e = 0;
                        c = a - b;
                    }
                }
                if(d==1 && e == 1)
                {
                    Console.Write("   {0} = {1} + {2} \n", a, b, a - b);
                    f = 1;
                }
            }
            if (f == 0)
            {
                Console.Write("{0} can not be expressed as sum of two prime numbers.", a);
            }
            Console.ReadLine();
        }
    }
}
