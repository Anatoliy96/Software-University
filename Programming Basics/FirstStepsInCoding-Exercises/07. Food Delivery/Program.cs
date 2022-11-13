using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· Брой пилешки менюта – цяло число в интервала[0 … 99]
            int chickenMenu = int.Parse(Console.ReadLine());
            //· Брой менюта с риба – цяло число в интервала[0 … 99]
            int fishMenu = int.Parse(Console.ReadLine());
            //· Брой вегетариански менюта – цяло число в интервала[0 … 99]
            int veganMenu = int.Parse(Console.ReadLine());

            double priceOfChickenMenu = 10.35;
            double priceOfFishMenu = 12.40;
            double priceOfVeganMenu = 8.15;

            double priceOfChicken = chickenMenu * priceOfChickenMenu;
            double priceOfFish = fishMenu * priceOfFishMenu;
            double priceOfVegan = veganMenu * priceOfVeganMenu;

            double totalPriceOfMenu = priceOfChicken + priceOfFish + priceOfVegan;

            double priceOfDesert = totalPriceOfMenu * 0.20;

            double priceOfDelivery = 2.50;

            double result = totalPriceOfMenu + priceOfDesert + priceOfDelivery;

            Console.WriteLine(result);
        }
    }
}
