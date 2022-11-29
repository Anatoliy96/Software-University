using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalPriceOfOrder(product, quantity);
        }

        static void TotalPriceOfOrder(string product, int quantity)
        {
            double sum = 0;

            if (product == "coffee")
            {
                sum = quantity * 1.50;
            }
            else if (product == "water")
            {
                sum = quantity * 1.00;
            }
            else if (product == "coke")
            {
                sum = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                sum = quantity * 2.00;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
