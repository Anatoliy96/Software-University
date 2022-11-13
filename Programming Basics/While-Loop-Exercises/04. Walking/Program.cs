using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            int sumOfSteps = 0;

            while ((command = Console.ReadLine()) != "Going home")
            {
                int stepsPerDay = int.Parse(command);
                sumOfSteps += stepsPerDay;

                if (sumOfSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    sumOfSteps -= 10000;
                    Console.WriteLine($"{sumOfSteps} steps over the goal!");
                    break;
                }
            }
            if (command == "Going home")
            {
                int stepsBeforeGoingHome = int.Parse(Console.ReadLine());
                sumOfSteps += stepsBeforeGoingHome;

                if (sumOfSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    sumOfSteps -= 10000;
                    Console.WriteLine($"{sumOfSteps} steps over the goal!");
                }
                else
                {
                    double diffrence = Math.Abs(sumOfSteps - 10000);
                    Console.WriteLine($"{diffrence} more steps to reach goal.");
                }
            }
        }
    }
}
