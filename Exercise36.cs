using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise36
    {
        static void Main (string[] args)
        {
            int a, b, c;
            Console.Write("Input a number of rows: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 0; b <= a; b++)
            {
                for(c=1; c<=a-b; c++)
                    Console.Write(" ");
                for (c = 1; c <= b; c++)
                    Console.Write("{0}", c);
                for (c = b - 1; c >= 1; c--)
                    Console.Write("{0}", c);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
