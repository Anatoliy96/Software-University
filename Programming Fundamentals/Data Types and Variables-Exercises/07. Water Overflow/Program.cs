using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                totalLiters += liters;

                if (totalLiters > 255)
                {
                    totalLiters -= liters;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

            }

            Console.WriteLine($"{totalLiters}");
        }
    }
}
