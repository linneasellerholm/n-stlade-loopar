using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nästlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x % 2 == 0)
                        Console.Write("o");
                    else
                        Console.Write("#");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            //Övning 2
            for (int y = 0; y < 11; y++)
            {
                for (int x = 0; x < 11; x++)
                {
                    if (y % 2 == 0)
                    {
                        if (x % 2 == 0)
                            Console.Write("o");
                        else
                            Console.Write("#");
                    }
                    else if (y % 2 != 0)
                    {
                        if (x % 2 == 0)
                            Console.Write("#");
                        else
                            Console.Write("o");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            //Övning 3
            for (int y = 10; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                        Console.Write("#");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            //Övning 4
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(".");
                }
                for (int z = 0; z < (7 - y); z++)
                    Console.Write("*");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            
            //Övning 5
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (y + x == 6 || y == x)
                        Console.Write("*");
                    else
                        Console.Write(".");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            
            //Övning 6
            for(int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if ((x < 4 && (y + x >= 6 || y<=x)) || (x > 2 && (y + x <= 6 || y >= x)))
                        Console.Write("*");
                    else
                        Console.Write(".");
                    
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            //Övning 7
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if ((x<5 && x + y >= 4 && y<=x+4) || (x>4 && x+y <= 12 && x<=y+4))
                        Console.Write("*");
                    else
                        Console.Write(".");

                }
                Console.WriteLine("");
            }
        }
    }
}
