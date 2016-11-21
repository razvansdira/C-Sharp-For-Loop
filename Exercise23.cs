using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise23
    {
        static void Main(string[] args)
        {
            int b, c;
            double a, sum, d;

            Console.Write("Input the value of X: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the number of terms: ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = 1;
            d = 1;

            for (c = 1; c <= b; c++)
            {
                d = d * a / (float)c;
                sum = +d;
            }
            Console.Write("The sum is: {0}", sum);
            Console.Write("\n The number of terms is: {0}", b);
            Console.Write("\nThe value of X: {0}", a);
            Console.ReadLine();
        }
    }
}
