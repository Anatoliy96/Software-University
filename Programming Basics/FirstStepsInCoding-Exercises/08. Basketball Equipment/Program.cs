using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneYearTax = int.Parse(Console.ReadLine());

            double basketballSneakersPrice = oneYearTax - (oneYearTax * 0.40);
            double basketballKitPrice = basketballSneakersPrice - (basketballSneakersPrice * 0.2);
            double basketballBallPrice = basketballKitPrice * 0.25;
            double basketballAcesories = basketballBallPrice * 0.20;

            double totalPrice = oneYearTax + basketballSneakersPrice + basketballKitPrice + basketballBallPrice + basketballAcesories;

            Console.WriteLine(totalPrice);
        }
    }
}
