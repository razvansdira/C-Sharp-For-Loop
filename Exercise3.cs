using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            int x, y, z=0;
            Console.Write("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first {0} natural number is : ", x);

            for (y=1; y<=x; y++)
            {
                Console.Write(" {0}",y);
                z = z + y;              
            }
            Console.Write("\nThe sum of natural number upto {0} terms is {1}.", x,z);
            Console.ReadLine();
        }
    }
}
