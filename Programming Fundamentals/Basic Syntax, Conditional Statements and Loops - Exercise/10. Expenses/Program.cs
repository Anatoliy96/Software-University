
using System;

namespace _10._Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            
            double headsetCost = (lostGamesCount / 2) * headsetPrice;
            double miceCost = (lostGamesCount / 3) * mousePrice;
            double keyboardCost = (lostGamesCount / 6) * keyboardPrice;
            double displayCost = (lostGamesCount / 12) * displayPrice;
            double totalExpenses = headsetCost + miceCost + keyboardCost + displayCost;



            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
