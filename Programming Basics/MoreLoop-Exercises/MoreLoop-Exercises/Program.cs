using System;

namespace MoreLoop_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double countOfTournaments = 0;
            double countOfWins = 0;
            double pointsOfTournaments = 0;

            for (int i = 0; i < numberOfTournaments; i++)
            {
                string phaseOfTournament = Console.ReadLine();

                if (phaseOfTournament == "W")
                {
                    startingPoints += 2000;
                    pointsOfTournaments += 2000;
                    countOfWins++;
                }
                else if (phaseOfTournament == "F")
                {
                    startingPoints += 1200;
                    pointsOfTournaments += 1200;
                }
                else if (phaseOfTournament == "SF")
                {
                    startingPoints += 720;
                    pointsOfTournaments += 720;
                }

                countOfTournaments++;
            }
            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(pointsOfTournaments / countOfTournaments)}");
            Console.WriteLine($"{countOfWins / countOfTournaments * 100:f2}%");
            
        }
    }
}
