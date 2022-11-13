using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                double discount = pricePerNight * 0.05;
                pricePerNight -= discount;
            }

            double totalAmount = pricePerNight * nights;
            double expense = budget * (percent / 100.0);
            double sum = totalAmount + expense;

            if (sum <= budget)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"{moneyNeeded:f2} leva needed.");
            }
        }
    }
}
