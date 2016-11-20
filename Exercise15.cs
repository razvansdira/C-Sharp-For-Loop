using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            int x, y, z=1;

            Console.Write("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (y = 1; y <= x; y++)
                z = z * y;
            Console.Write("The factorial of {0} is equal with {1}.", x, z);

            Console.ReadLine();
        }
    }
}
