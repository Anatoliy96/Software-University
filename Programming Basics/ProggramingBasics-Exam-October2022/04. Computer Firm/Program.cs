using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double numberOfSales = 0;
            double averageRaiting = 0;
            double average = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                double raiting = number % 10;

                double possibleSales = number / 10;

                if (raiting == 2)
                {
                    averageRaiting += raiting;
                }

                else if (raiting == 3)
                {
                    possibleSales *= 0.50;
                    numberOfSales += possibleSales;
                    averageRaiting += raiting;
                }
                else if (raiting == 4)
                {
                    possibleSales *= 0.70;
                    numberOfSales += possibleSales;
                    averageRaiting += raiting;
                }
                else if (raiting == 5)
                {
                    possibleSales *= 0.85;
                    numberOfSales += possibleSales;
                    averageRaiting += raiting;
                }
                else if (raiting == 6)
                {
                    possibleSales *= 100 / 100;
                    numberOfSales += possibleSales;
                    averageRaiting += raiting;
                }
            }

            average = averageRaiting / n;

            Console.WriteLine($"{numberOfSales:f2}");
            Console.WriteLine($"{average:f2}");
        }
    }
}
