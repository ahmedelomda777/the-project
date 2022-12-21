using System;

namespace perfect_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int y = int.Parse(Console.ReadLine());
            for (int i = x; i < y; i++)
            {
                int z=0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        z = z + k;
                    }
                }
                    if(z==i)
                    {
                        Console.WriteLine(i);
                    }
                
            }
        }
    }
}