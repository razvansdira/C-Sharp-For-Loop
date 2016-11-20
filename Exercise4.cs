using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise4
    {static void Main(string[] args)
        {
            int x, y, sum = 0;
            double avg;

            Console.WriteLine("Input ten numbers:");

            for(y=1; y<=10; y++)
            {
                Console.Write("Number {0}: ", y);
                x = Convert.ToInt32(Console.ReadLine());

                sum += x;
            }
            Console.Write("The sum of ten number is: {0}", sum);
            avg = sum / 10.0;

            Console.Write("\nThe average is: {0}", avg);
            Console.ReadLine();
        }
    }
}
