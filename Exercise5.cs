using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise5
    {
        static void Main(string[ ] args)
        {
            int a, b,c;

            Console.Write("Input number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=1; b<=a; b++)
            {
                c = b * b * b;
                Console.WriteLine("Number is: {0} and cube is: {1}. ", b, c);
            }
            Console.ReadLine();
        }
    }
}
