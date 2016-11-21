using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise25
    {
        static void Main(string[] args)
        {
            int a, b, c=0;
            Console.Write(" Input the number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=1; b<=a; b++)
            {
                Console.Write("{0} ", b*b);
                c += b * b;
            }
            Console.Write("\n The sum of square natural upto {0} terms = {1}", a, c);
            Console.ReadLine();
        }
    }
}
