using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            double money = 0;
            // · "Nuts" with a price of 2.0

            //· "Water" with a price of 0.7

            //· "Crisps" with a price of 1.5

            //· "Soda" with a price of 0.8

            //· "Coke" with a price of 1.0
            double priceOfNuts = 2.0;
            double priceOfWater = 0.7;
            double priceOfCrisps = 1.5;
            double priceOfSoda = 0.8;
            double priceOfCoke = 1.0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    money += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string product = command;

                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }

                if (product == "Nuts")
                {
                    if (money >= priceOfNuts)
                    {
                        money -= priceOfNuts;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money >= priceOfWater)
                    {
                        money -= priceOfWater;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= priceOfCrisps)
                    {
                        money -= priceOfCrisps;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= priceOfSoda)
                    {
                        money -= priceOfSoda;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= priceOfCoke)
                    {
                        money -= priceOfCoke;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
