using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise41
    {
        static void Main(string[] args)
        {
            int x, i=1, j, r, s=0;
            Console.Write(" Input a number to convert: ");
            x = Convert.ToInt32(Console.ReadLine());
            r = x;

            for(j=x; j>0; j /= 2)
            {
                s += (x % 2) * i;
                i *= 10;
                x /= 2;
            }
            Console.Write("The binary is: {0}.", s);
            Console.ReadLine();
        }
    }
}
