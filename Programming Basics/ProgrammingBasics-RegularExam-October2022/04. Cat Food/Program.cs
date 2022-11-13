using System;

namespace _04._Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCats = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            double gramsFood = 0;

            for (int i = 0; i < numberOfCats; i++)
            {
                double food = double.Parse(Console.ReadLine());

                if (food >= 100 && food < 200)
                {
                    group1++;
                    gramsFood += food;
                }
                else if (food >= 200 && food < 300)
                {
                    group2++;
                    gramsFood += food;
                }
                else if (food >= 300 && food < 400)
                {
                    group3++;
                    gramsFood += food;
                }
            }
            double kilogramsFood = gramsFood / 1000;
            double pricePerDay = kilogramsFood * 12.45;

            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {pricePerDay:f2} lv.");
        }
    }
}
