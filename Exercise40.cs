using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise40
    {
        static void Main(string[] args)
        {
            int a, b, c, d=1;
            char abc = 'A';

            Console.Write("  Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (c = 1; c <= a; c++)
            {
                for (b = 0; b <= (d / 2); b++)
                {
                    Console.Write("{0}", abc++);
                }
                abc--; abc--;

                for (b = 0; b < (d / 2); b++)
                {
                    Console.Write("{0}", abc--);
                }
                d += 2;
                abc = 'A';
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
