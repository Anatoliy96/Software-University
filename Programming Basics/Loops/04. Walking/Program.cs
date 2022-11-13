using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int sumOfSteps = 0;
            int diffrence = 0;

            while ((command = Console.ReadLine()) != "Going home")
            {
                int steps = int.Parse(command);

                sumOfSteps += steps;

                if (sumOfSteps >= 10000)
                {
                    diffrence = sumOfSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{diffrence} steps over the goal!");
                    return;
                }
            }

            if (command == "Going home")
            {
                int stepsBeforeGoingHome = int.Parse(Console.ReadLine());
                sumOfSteps += stepsBeforeGoingHome;

                if (sumOfSteps <= 10000)
                {
                    diffrence = Math.Abs(sumOfSteps - 10000);
                    Console.WriteLine($"{diffrence} more steps to reach goal.");
                }
                else
                {
                    diffrence = sumOfSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{diffrence} steps over the goal!");
                }
            }
        }
    }
}
