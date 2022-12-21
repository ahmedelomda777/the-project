using System;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int y = int.Parse(Console.ReadLine());
            int z = 0;
            for (int i = x; i <= y; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    if (i % a == 0)
                        z++;
                }
                if (z == 2)
                {
                    Console.WriteLine(i);
                    z = 0;
                }
                else
                    z=0;
                }
            }


        }
    }
