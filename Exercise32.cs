using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise32
    {
        static void Main(string[] args)
        {
            int a, b, c=0;
            Console.Write("Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b=2; b<=a/2; b++)
            {
                if (a % b == 0)
                    c++;
            }
            if (c == 0 && a != 1)
                Console.Write(" {0} is a prime number.", a);
            else
                Console.Write(" {0} isn't a prime number.", a);
            
            Console.ReadLine();
        }
    }
}
