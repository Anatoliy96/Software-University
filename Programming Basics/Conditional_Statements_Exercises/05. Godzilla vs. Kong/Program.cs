using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStatistician = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double discount = 0;

            double sumForDecor = budget * 0.1;
            double sumForClothes = numberOfStatistician * priceForClothes;

            if (numberOfStatistician > 150)
            {
                discount = sumForClothes * 0.1;
                sumForClothes -= discount;
            }

            double totalSum = sumForDecor + sumForClothes;

            if (totalSum <= budget)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
        }
    }
}
