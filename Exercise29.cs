using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise29
    {
        static void Main(string[] args)
        {
            int a, b, c, sum = 0;
            Console.Write("Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            for(b=a; a!=0; a=a/10)
            {
                c = a % 10;
                sum = sum + (c * c * c);
            }
            if (sum == b)
                Console.WriteLine("{0} is an Armstrong number.",b);
            else
                Console.WriteLine("{0} is not an Armstrong number.",b);
            Console.ReadLine();
        }
    }
}
