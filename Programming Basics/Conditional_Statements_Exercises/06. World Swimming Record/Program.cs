using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());

            double bonusTime = Math.Floor(distanceInMeters / 15) * 12.5;
            
            double totalTime = distanceInMeters * distance + bonusTime;

            if (totalTime < recordInSeconds)
            { 
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");

            }
            else
            { 
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
