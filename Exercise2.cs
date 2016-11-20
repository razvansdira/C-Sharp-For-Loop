using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise2
    {
        static void Main (String[] args)
        {
            int x, y=0;
            Console.WriteLine(" The sum of first ten natural numbers: ");

            for (x = 1; x <= 10; x++)
                y = y + x;
                Console.Write(" {0}", y);
            Console.ReadLine();
        }
    }
}
