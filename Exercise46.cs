using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise46
    {
        static void Main(string[] args)
        {
            int x, y;
            double s, i = 0, dec = 0;
            Console.Write(" Input a binary number to convert: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = x;


            while (x != 0)
            {
                s = x % 10;
                dec += s * Math.Pow(2, i);
                x /= 10;
                i++;
            }
            Console.Write("The decimal number is: {0}.", dec);
            Console.ReadLine();
        }
    }
}
