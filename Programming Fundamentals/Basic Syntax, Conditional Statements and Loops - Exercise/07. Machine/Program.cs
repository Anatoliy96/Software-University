using System;

namespace _07._Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            string product;

            double money = 0;
            double priceOfNuts = 2.0;
            double priceOfWater = 0.7;
            double priceOfCrisps = 1.5;
            double priceOfSoda = 0.8;
            double priceOfCoke = 1;
            double moneyLeft = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }

                money += coins;
            }

            while ((product = Console.ReadLine()) != "End")
            {
                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (product == "Nuts" && money >= priceOfNuts)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= priceOfNuts;
                }
                else if (product == "Water" && money >= priceOfWater)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= priceOfWater;
                }
                else if (product == "Crisps" && money >= priceOfCrisps)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= priceOfCrisps;
                }
                else if (product == "Soda" && money >= priceOfSoda)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= priceOfSoda;
                }
                else if (product == "Coke" && money >= priceOfCoke)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= priceOfCoke;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
