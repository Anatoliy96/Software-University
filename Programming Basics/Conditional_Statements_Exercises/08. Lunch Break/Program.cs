using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double timeForLunch = breakTime / 8.0;
            double timeForBreak = breakTime / 4.0;

            double timeLeft = breakTime - timeForLunch - timeForBreak;

            if (timeLeft >= episode)
            {
                double freeTime = timeLeft - episode;
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(freeTime)} minutes free time.");
            }
            else
            {
                double timeNeeded = episode - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}
