using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string vacation = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    vacation = "Camp";
                    budget *= 0.30;
                }
                else if (season == "winter")
                {
                    vacation = "Hotel";
                    budget *= 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    vacation = "Camp";
                    budget *= 0.40;
                }
                else if (season == "winter")
                {
                    vacation = "Hotel";
                    budget *= 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";

                if (season == "summer" || season == "winter")
                {
                    vacation = "Hotel";
                    budget *= 0.90;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacation} - {budget:f2}");
        }
    }
}
