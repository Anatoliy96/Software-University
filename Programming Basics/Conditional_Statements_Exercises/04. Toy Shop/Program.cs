using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double priceOfPuzzle = 2.60;
            double priceOfTalkingDoll = 3;
            double priceOfTeddyBear = 4.10;
            double priceOfMinions = 8.20;
            double priceOfTruck = 2;

            double discount = 0;
            double rent = 0;

            double sum = numberOfPuzzles * priceOfPuzzle + numberOfTalkingDolls * 3 + numberOfTeddyBears * 4.10 
                + numberOfMinions * 8.20 + numberOfTrucks * 2;

            double totalNumberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;

            if (totalNumberOfToys >= 50)
            {
                discount = sum * 0.25;
                sum -= discount;
            }


            rent = sum * 0.1;
            double profit = sum - rent;

            if (profit >= priceOfTrip)
            {
                double moneyLeft = profit - priceOfTrip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceOfTrip - profit;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

        }
    }
}
