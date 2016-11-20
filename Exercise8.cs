using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            int x, y, z=0;
            Console.Write("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are: ");

            for (y=1; y<=x; y++)
            {
                Console.WriteLine(" {0} ", 2 * y - 1);
                z += 2 * y - 1;
            }
            Console.Write("The sum of {0} odd natural number is: {1}",x, z);
            Console.ReadLine();
        }
    }
}
