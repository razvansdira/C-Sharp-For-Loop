using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise30
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, sum;

            Console.Write("Input starting number of range: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range :");
            d = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Armstrong numbers in given range are: ");
            for (b = a; b <= d; b++)
            {
                c = b;
                sum = 0;

                while (c != 0)
                {
                    e = c % 10;
                    c = c / 10;
                    sum = sum + (e * e * e);
                }
                if (sum == b)
                    Console.Write("{0} ", b);
            }
            Console.ReadLine();
        }
    }
}
