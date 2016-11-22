using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise38
    {
        static void Main(string[] args)
        {
            int a, b, c, sum=0;
            Console.Write(" Input a palindrome or not: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(b=a; a!=0; a=a/10)
            {
                c = a % 10;
                sum = sum * 10 + c;
            }
            if (b == sum)
                Console.Write("{0} is a palindrome.",b);
            else
                Console.Write("{0} isn't a palindrome.",b);
            Console.ReadLine();
        }
    }
}
