using System;

namespace NestedConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double pricePerNightInStudio = 0;
            double pricePerNightInApartment = 0;

            

            if (mounth == "May" || mounth == "October")
            {
                pricePerNightInStudio = 50.00;
                pricePerNightInApartment = 65.00;

                if (nights > 14)
                {
                    pricePerNightInStudio *= 0.70;
                    pricePerNightInApartment *= 0.90;
                }
                else if (nights > 7)
                {
                    pricePerNightInStudio *= 0.95;
                    pricePerNightInApartment = 65.00;
                }

                Console.WriteLine($"Apartment: {pricePerNightInApartment * nights:f2} lv.");
                Console.WriteLine($"Studio: {pricePerNightInStudio * nights:f2} lv.");
            }
            else if (mounth == "June" || mounth == "September")
            {
                pricePerNightInStudio = 75.20;
                pricePerNightInApartment = 68.70;

                if (nights > 14)
                {
                    pricePerNightInStudio *= 0.90;
                    pricePerNightInApartment *= 0.80;
                }
                else
                {
                    pricePerNightInStudio = 75.20;
                    pricePerNightInApartment = 68.70;
                }

                Console.WriteLine($"Apartment: {pricePerNightInApartment * nights:f2} lv.");
                Console.WriteLine($"Studio: {pricePerNightInStudio * nights:f2} lv.");
            }
            else if (mounth == "July" || mounth == "August")
            {
                pricePerNightInStudio = 76.00;
                pricePerNightInApartment = 77.00;

                if (nights > 14)
                {
                    pricePerNightInStudio = 76.00;
                    pricePerNightInApartment = pricePerNightInApartment * 0.90;
                }
                else
                {
                    pricePerNightInStudio = 76.00;
                    pricePerNightInApartment = 77.00;
                }

                Console.WriteLine($"Apartment: {pricePerNightInApartment * nights:f2} lv.");
                Console.WriteLine($"Studio: {pricePerNightInStudio * nights:f2} lv.");
            }
        }
    }
}
