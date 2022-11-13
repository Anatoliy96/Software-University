using System;

namespace NestedConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            double sum = 0;

            if (city == "Sofia")
            {
                if (0 <= price && price <= 500)
                {
                    sum = price * 0.05;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (500 <= price && price <= 1000)
                {
                    sum = price * 0.07;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (1000 <= price && price <= 10000)
                {
                    sum = price * 0.08;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (price > 10000)
                {
                    sum = price * 0.12;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (0 <= price && price <= 500)
                {
                    sum = price * 0.045;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (500 <= price && price <= 1000)
                {
                    sum = price * 0.075;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (1000 <= price && price <= 10000)
                {
                    sum = price * 0.10;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (price > 10000)
                {
                    sum = price * 0.13;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= price && price <= 500)
                {
                    sum = price * 0.055;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (500 <= price && price <= 1000)
                {
                    sum = price * 0.08;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (1000 <= price && price <= 10000)
                {
                    sum = price * 0.12;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (price > 10000)
                {
                    sum = price * 0.145;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}