using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = 0;

            if (roomType == "room for one person")
            {
                price = 18.00;
                price *= days - 1;
            }
            else if (roomType == "apartment")
            {
                price = 25.00;
                price *= days - 1;

                if (days < 10)
                {
                    price *= 0.70;
                }
                else if (days >= 10 && days <= 15)
                {
                    price *= 0.65;
                }
                else if (days > 15)
                {
                    price *= 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35.00;
                price *= days - 1;

                if (days < 10)
                {
                    price *= 0.90;
                }
                else if (days >= 10 && days <= 15)
                {
                    price *= 0.85;
                }
                else if (days > 15)
                {
                    price *= 0.80;
                }
            }
            if (evaluation == "positive")
            {
                price *= 1.25;
            }
            else if (evaluation == "negative")
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
