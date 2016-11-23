using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise55
    {
        public static void Main(string[] args)
        {
            int n, q, dn = 0, m, l, p, s;

            Console.Write(" Input a decimal number: ");
            n = Convert.ToInt32(Console.ReadLine());
            q = n;

            for (l = q; l > 0; l = l / 16)
            {
                p = l % 16;
                if (p < 10)
                    p += 48;
                else
                    p += 55;
                dn = dn * 100 + p;
            }
            Console.Write("The hexadecimal number is: ");

            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char)s);
            }
            Console.ReadLine();
        }  
    }
}
