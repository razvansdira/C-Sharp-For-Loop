using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            int i, j, k, l=1;
            Console.Write(" Input a number: ");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= k; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0 } ", l++);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
