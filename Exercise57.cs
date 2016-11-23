using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise57
    {
        static void Main(string[] args)
        {
            int x, y;
            string a, b = "";

            Console.Write(" Input a word: ");
            a = Console.ReadLine();

            x = a.Length - 1;
            for (y = x; y >= 0; y--)
            {
                b += a[y];
            }
            Console.Write("The reverse order is: {0}", b);
            Console.ReadLine();
        }
    }
}
