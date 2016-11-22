using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise37
    {
        static void Main(string[] args)
        {
            int x, y, z, sum=0;
            Console.Write(" Input a series of number: ");
            x = Convert.ToInt32(Console.ReadLine());

            for(y=x; y!=0; y=y/10)
            {
                z = y % 10;
                sum = sum * 10 + z;
            }
            Console.Write("The reverse order is: {0}", sum);
            Console.ReadLine();
        }
    }
}
