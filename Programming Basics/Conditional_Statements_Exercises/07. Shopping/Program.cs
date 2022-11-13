using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int CPU = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double discount = 0;

            double sumOfVideoCards = videoCard * 250;

            double priceOfCPU = sumOfVideoCards * 0.35;
            double sumOfCPU = CPU * priceOfCPU;

            double priceOfRam = sumOfVideoCards * 0.10;
            double sumOfRam = ramMemory * priceOfRam;

            double totalSum = sumOfVideoCards + sumOfCPU + sumOfRam;

            if (videoCard > CPU)
            {
                discount = totalSum * 0.15;
                totalSum -= discount;
            }

            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }

        }
    }
}
