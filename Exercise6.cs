using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 0; b <= 10; b++)
            {
                Console.WriteLine("{0} x {1} = {2} ", a, b, a * b);
            }
            Console.ReadLine();
        }
    }
}
