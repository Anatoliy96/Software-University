using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfScreening = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColums = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double sum = 0;

            if (typeOfScreening == "Premiere")
            {
                sum = premiere * numberOfRows * numberOfColums;
                Console.WriteLine($"{sum:f2} leva");
            }
            else if (typeOfScreening == "Normal")
            {
                sum = normal * numberOfRows * numberOfColums;
                Console.WriteLine($"{sum:f2} leva");
            }
            else if (typeOfScreening == "Discount")
            {
                sum = discount * numberOfRows * numberOfColums;
                Console.WriteLine($"{sum:f2} leva");
            }
        }
    }
}
