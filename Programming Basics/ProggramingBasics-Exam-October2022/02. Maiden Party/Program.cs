using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfMaidenParty = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int LuckySuprise = int.Parse(Console.ReadLine());


            double totalPrice = loveMessages * 0.60 + waxRoses * 7.20 + keychains * 3.60 + caricatures * 18.20 + LuckySuprise * 22;
            double numberOfArticles = loveMessages + waxRoses + keychains + caricatures + LuckySuprise;

            if (numberOfArticles >= 25)
            {
               double discount = totalPrice * 0.35;
               totalPrice -= discount;
            }

            double sum = totalPrice * 0.9;

            if (sum >= priceOfMaidenParty)
            {
                double moneyLeft = sum - priceOfMaidenParty;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceOfMaidenParty - sum;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
