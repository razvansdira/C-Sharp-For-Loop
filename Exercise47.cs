using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise47
    {
        static void Main (String[] args)
        {
            int x, y, z, w, t, s=0;
            Console.Write(" Input a strong number or not: ");
            x = Convert.ToInt32(Console.ReadLine());

            y = x;
            for (z = x; z > 0; z /= 10)
            {
                t = 1;
                for (w = 1; w < z % 10; w++)
                    t *= w;
                s += t;
            }
            if (s==y)
                Console.Write("{0} is a strong number.", y);
            else
                Console.Write("{0} isn't a strong number.",y);
            Console.ReadLine();
        }
    }
}
