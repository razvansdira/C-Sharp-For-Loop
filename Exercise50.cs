using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise50
    {
        static void Main(string[] args)
        {
            int x, i = 1, j, r, s = 0;
            Console.Write(" Input a number to convert: ");
            x = Convert.ToInt32(Console.ReadLine());
            r = x;

            for (j = x; j > 0; j /= 8)
            {
                s += (j % 8) * i;
                i *= 10;
                x /= 2;
            }
            Console.Write("The octal number is: {0}.", s);
            Console.ReadLine();
        }
    }
}
