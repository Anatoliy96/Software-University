using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            int competingFactoryProduction = int.Parse(Console.ReadLine());

            int production = 0;

            for (int day = 1; day <= 30; day++)
            {
                int dayProduction = biscuitsPerDayPerWorker * workerCount;

                if (day % 3 == 0)
                {
                    dayProduction = (int)(dayProduction * 0.75);
                }

                production += dayProduction;
            }

            Console.WriteLine($"You have produced {production} biscuits for the past month.");

            double diffPercent = (double)(production - competingFactoryProduction) / competingFactoryProduction * 100;

            if (diffPercent > 0)
            {
                Console.WriteLine($"You produce {diffPercent:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(diffPercent):f2} percent less biscuits.");
            }
        }
    }
}
