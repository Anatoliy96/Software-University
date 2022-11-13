using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budgetOfGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherMan = int.Parse(Console.ReadLine());

            double priceOfBoat = 0;
            double discount = 0.95;

            if (season == "Spring")
            {
                priceOfBoat += 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceOfBoat += 4200;

            }
            else if (season == "Winter")
            {
                priceOfBoat += 2600;
            }
            if (numberOfFisherMan <= 6)
            {
                priceOfBoat *= 0.9;
            }
            else if (numberOfFisherMan > 7 && numberOfFisherMan <= 11)
            {
                priceOfBoat *= 0.85;
            }
            else if (numberOfFisherMan >= 12)
            {
                priceOfBoat *= 0.75;
            }
            if (numberOfFisherMan % 2 == 0 && season != "Autumn")
            {
                priceOfBoat *= discount;
            }
            if (budgetOfGroup >= priceOfBoat)
            {
                double moneyLeft = budgetOfGroup - priceOfBoat;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = priceOfBoat - budgetOfGroup;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
