using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int .Parse(Console.ReadLine());
            int secondTime = int .Parse(Console.ReadLine());
            int thirdTime = int .Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int totalTimeInMinutes = totalTime / 60;
            int totalTimeInSeconds = totalTime % 60;

            if (totalTimeInSeconds < 10)
            {
                Console.WriteLine($"{totalTimeInMinutes}:0{totalTimeInSeconds}");
            }
            else
            {
                Console.WriteLine($"{totalTimeInMinutes}:{totalTimeInSeconds}");
            }
        }
    }
}
