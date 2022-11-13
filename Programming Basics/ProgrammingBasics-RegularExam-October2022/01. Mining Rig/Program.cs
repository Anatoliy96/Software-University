using System;

namespace _01._Mining_Rig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = int.Parse(Console.ReadLine());
            int adapterPrice = int.Parse(Console.ReadLine());
            double currentConsumption = double.Parse(Console.ReadLine());
            double profitPerDay = double.Parse(Console.ReadLine());

            double priceOfVideoCard = videoCardPrice * 13;
            double priceOfAdapter = adapterPrice * 13;
            double totalSpendMoney = priceOfVideoCard + priceOfAdapter + 1000;
            double profitFromOneCard = profitPerDay - currentConsumption;
            double totalProfitFromCards = 13 * profitFromOneCard;
            double daysOfReturning = totalSpendMoney / totalProfitFromCards;

            Console.WriteLine($"{totalSpendMoney}");
            Console.WriteLine($"{Math.Ceiling(daysOfReturning)}");
        }
    }
}
