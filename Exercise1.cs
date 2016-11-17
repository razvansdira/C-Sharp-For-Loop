using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine(" The first ten natural numbers: ");

            for (x = 1; x <= 10; x++)
                Console.Write(" {0}", x);
            Console.ReadLine();
        }
    }
}
