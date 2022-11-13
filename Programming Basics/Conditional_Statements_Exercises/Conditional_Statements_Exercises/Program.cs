using System;

namespace Conditional_Statements_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double timeForLunch = breakTime / 8.0;
            double timeForRest = breakTime / 4.0;

            double time = breakTime - timeForLunch - timeForRest;

            if (time >= episode)
            {
                var timeLeft = time - episode; 
                Console.WriteLine($"You have enough time to watch {series}" +
                    $" and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                var timeNeeded = episode - time;
                Console.WriteLine($"You don't have enough time to watch {series}" +
                    $", you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
        }
    }
}
