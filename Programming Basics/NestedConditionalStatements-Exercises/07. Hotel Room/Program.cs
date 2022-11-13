using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartament = 0;

            if (mounth == "May" || mounth == "October")
            {
                priceForStudio = 50.00;
                priceForApartament = 65.00;

                if (numberOfNights > 14)
                {
                    priceForStudio *= 0.70;
                    priceForApartament *= 0.90;
                }
                else if (numberOfNights > 7)
                {
                    priceForStudio *= 0.95;
                    priceForApartament = 65.00;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                priceForStudio = 75.20;
                priceForApartament = 68.70;

                if (numberOfNights > 14)
                {
                    priceForStudio *= 0.80;
                    priceForApartament *= 0.90;
                }
                else
                {
                    priceForStudio = 75.20;
                    priceForApartament = 68.70;
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                priceForStudio = 76.00;
                priceForApartament = 77.00;

                if (numberOfNights > 14)
                {
                    priceForStudio = 76.00;
                    priceForApartament *= 0.90;
                }
                else
                {
                    priceForStudio = 76.00;
                    priceForApartament = 77.00;
                }
            }
            Console.WriteLine($"Apartment: {priceForApartament * numberOfNights:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio * numberOfNights:f2} lv.");
        }
    }
}
