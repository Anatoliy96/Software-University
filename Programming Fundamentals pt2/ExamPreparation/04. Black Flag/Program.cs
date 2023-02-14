using System;

namespace _04._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dayliPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlundered = 0;

            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlundered += dayliPlunder;

                if (i % 3 == 0)
                {
                    double additionalPlunder = dayliPlunder * 0.50;
                    totalPlundered += additionalPlunder;
                }
                if (i % 5 == 0)
                {
                    totalPlundered *= 0.70;
                }
            }

            if (totalPlundered >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlundered:f2} plunder gained.");
            }
            else
            {
                double percentageNeeded = totalPlundered / expectedPlunder * 100;

                Console.WriteLine($"Collected only {percentageNeeded:f2}% of the plunder.");
            }
        }
    }
}
