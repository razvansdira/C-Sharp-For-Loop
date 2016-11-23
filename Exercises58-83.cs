using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_For_Loop
{
    class Exercises58_83
    {
        static void Main(string[] args)
        {
            int r, c;

            for(r=0; r<=6; r++)
            {
                for(c=0; c<=6; c++)
                {
                    if (c == 1 || ((r == 0 || r == 3) && c > 1 && c < 5) || (c == 5 && r != 0 && r < 3) || (c == r - 1 && r > 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (r = 0; r <= 6; r++)
            {
                for (c = 0; c <= 6; c++)
                {
                    if (((c == 1 || c == 5) && r != 0) || ((r == 0 || r == 3) && (c > 1 && c < 5)))
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (r = 0; r <= 6; r++)
            {
                for (c = 0; c <= 6; c++)
                {
                    if (((r == 0 || r == 6) && c >= 0 && c <= 6) || r + c == 6)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (r = 0; r <= 6; r++)
            {
                for (c = 0; c <= 6; c++)
                {
                    if (((c == 1 || c == 5) && r < 5) || (r == 6 && c == 3) || (r == 5 && (c == 2 || c == 4)))
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
                            Console.Write("\n");

            for (r = 0; r <= 6; r++)
            {
                for (c = 0; c <= 6; c++)
                {
                    if (((c == 1 || c == 5) && r != 0) || ((r == 0 || r == 3) && (c > 1 && c < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (r = 0; r <= 6; r++)
            {
                for (c = 0; c <= 6; c++)
                {
                    if (c == 1 || c == 5 || (r == c && c != 0 && c != 6))
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}