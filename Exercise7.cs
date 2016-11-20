using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 1; b <= 8; b++)
            {
                for(c=1; c<=a; c++)
                {
                    if(c<=a-1)
                        Console.Write(" {0} x {1} = {2} ", c, b, c * b);
                    else
                        Console.Write(" {0} x {1} = {2} ", c, b, b * c);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
