using System;

namespace _03._Gaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game;

            double totalSpent = 0;
            double spent = 0;
            double outFall4Price = 39.99;
            double csOGPrice = 15.99;
            double zplinterZellPrice = 19.99;
            double honored2Price = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOriginsEditionPrice = 39.99;

            while ((game = Console.ReadLine()) != "Game Time")
            {
                if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch"
                    && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                if (game == "OutFall 4" && budget < outFall4Price || game == "CS: OG" && budget < csOGPrice 
                    || game == "Zplinter Zell" && budget < zplinterZellPrice || game == "Honored 2" && budget < honored2Price 
                    || game == "RoverWatch" && budget < roverWatchPrice || game == "RoverWatch Origins Edition" && budget < roverWatchOriginsEditionPrice)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                if (game == "OutFall 4" && budget >= outFall4Price)
                {
                    budget -= outFall4Price;
                    spent += outFall4Price;
                    Console.WriteLine($"Bought {game}");
                }
                else if (game == "CS: OG" && budget >= csOGPrice)
                {
                    budget -= csOGPrice;
                    spent += csOGPrice;
                    Console.WriteLine($"Bought {game}");
                }
                else if (game == "Zplinter Zell" && budget >= zplinterZellPrice)
                {
                    budget -= zplinterZellPrice;
                    spent += zplinterZellPrice;
                    Console.WriteLine($"Bought {game}");
                }
                else if (game == "Honored 2" && budget >= honored2Price)
                {
                    budget -= honored2Price;
                    spent += honored2Price;
                    Console.WriteLine($"Bought {game}");
                }
                else if (game == "RoverWatch" && budget >= roverWatchPrice)
                {
                    budget -= roverWatchPrice;
                    spent += roverWatchPrice;
                    Console.WriteLine($"Bought {game}");
                }
                else if (game == "RoverWatch Origins Edition" && budget >= roverWatchOriginsEditionPrice)
                {
                    budget -= roverWatchOriginsEditionPrice;
                    spent += roverWatchOriginsEditionPrice;
                    Console.WriteLine($"Bought {game}");
                }

                totalSpent = spent;
            }

            if (budget <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
