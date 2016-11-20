using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise16
    {
        static void Main(string[] args)
        {
            int x, y, z=0;

            Console.Write(" Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("The even numbers are: ");

            for (y=1; y<=x; y++)
            {
                Console.Write("{0 } ", 2 * y);
                z += 2*y;
            }
            Console.Write("\n The sum is: {0}", z);
            Console.ReadLine();
        }
    }
}
