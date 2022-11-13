using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfLaundry = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            double countOfMoney = 0;
            int toyCount = 0;
            double savings = 0;
            double toySell = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    countOfMoney += 10;
                    savings += countOfMoney;
                    savings -= 1;
                }
                else
                {
                    toyCount++;
                }
            }

            toySell = toyCount * priceOfToy;
            double amountOfSaving = savings + toySell;

            if (amountOfSaving >= priceOfLaundry)
            {
                double moneyLeft = amountOfSaving - priceOfLaundry;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = priceOfLaundry - amountOfSaving;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
