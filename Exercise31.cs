using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise31
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Input a number of rows: ");
            c = Convert.ToInt32(Console.ReadLine());

            for (a = 0; a <= c; a++)
            {
                for (b = 1; b <= c - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (a = c-1; a >=1; a--)
            {
                for (b = 1; b <= c - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2 * a - 1; b++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
