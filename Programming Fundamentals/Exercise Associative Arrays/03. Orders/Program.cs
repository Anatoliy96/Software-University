using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, int> productsQantity = new Dictionary<string, int>();

            string command;
            
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] tokens = command.Split();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!productsQantity.ContainsKey(product))
                {
                    productsQantity.Add(product, quantity);
                    productsPrice.Add(product, price);
                }
                else
                {
                    productsQantity[product] += quantity;

                    if (productsPrice[product] != price)
                    {
                        productsPrice[product] = price;
                    }
                }
                productsPrice[product] *= productsQantity[product];
            }
            foreach (var kvpProduct in productsPrice)
            {
                Console.WriteLine($"{kvpProduct.Key} -> {kvpProduct.Value:f2}");
            }
        }
    }
}
