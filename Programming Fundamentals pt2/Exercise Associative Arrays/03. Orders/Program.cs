using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (decimal Price, int Quantity)> products = new Dictionary<string, (decimal Price, int Quantity)>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = (price, quantity);
                }
                else
                {
                    products[name] = (price, products[name].Quantity + quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in products)
            {
                decimal totalPrice = kvp.Value.Price * kvp.Value.Quantity;
                Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
            }
        }
    }
}
