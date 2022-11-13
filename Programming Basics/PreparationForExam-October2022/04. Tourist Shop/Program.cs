using System;

namespace _04._Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command;
            int productCount = 0;
            double totalAmount = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                double priceOfProduct = double.Parse(Console.ReadLine());

                productCount++;

                if (productCount % 3 == 0)
                {
                    priceOfProduct /= 2;
                }

                if (priceOfProduct > budget)
                {
                    double moneyNeed = priceOfProduct - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeed:f2} leva!");
                    return;
                }

                budget -= priceOfProduct;

                totalAmount += priceOfProduct;
            }

            if (command == "Stop")
            {
                Console.WriteLine($"You bought {productCount} products for {totalAmount:f2} leva.");
            }
        }
    }
}
