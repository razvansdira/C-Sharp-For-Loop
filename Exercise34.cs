using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise34
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            Console.Write("Input starting number of range: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range :");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  The prime numbers are: ");

            for (b = a; b <= d; b++)
            {
                c = 0;

                for (e = 2; e <= b / 2; e++)
                {
                    if (b % e == 0)
                        c++;    
                }
                if (c == 0 && b != 1)
                    Console.Write("{0} ", b);
            }
            Console.ReadLine();
        }
    }
}
