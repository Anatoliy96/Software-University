using System;

namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocations = int.Parse(Console.ReadLine());

            double retrieved = 0;
            double averageRetrieved = 0;

            for (int i = 0; i < numberOfLocations; i++)
            {
                double averageGoldPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());

                retrieved = 0;

                for (int j = 0; j < days; j++)
                {
                    double minedGoldForDay = double.Parse(Console.ReadLine());

                    retrieved += minedGoldForDay;
                }
                averageRetrieved = retrieved / days;

                if (averageRetrieved >= averageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageRetrieved:f2}.");
                    continue;
                }
                else
                {
                    double goldNeeded = averageGoldPerDay - averageRetrieved;
                    Console.WriteLine($"You need {goldNeeded:f2} gold.");
                }
            }
        }
    }
}
