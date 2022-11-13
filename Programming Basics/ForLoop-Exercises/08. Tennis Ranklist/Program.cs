using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int F = 1200;
            int W = 2000;
            int SF = 720;

            int thisYearPoints = 0;
            double averageSum = 0;
            double countOfWins = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                string phaseOfTournament = Console.ReadLine();

                if (phaseOfTournament == "F")
                {
                    thisYearPoints += F;
                }
                else if (phaseOfTournament == "SF")
                {
                    thisYearPoints += SF;
                }
                else if (phaseOfTournament == "W")
                {
                    thisYearPoints += W;
                    countOfWins++;
                }
            }

            int totalPoints = points + thisYearPoints;
            Console.WriteLine($"Final points: {totalPoints}");

            averageSum = thisYearPoints / numberOfTournaments;
            Console.WriteLine($"Average points: {Math.Floor(averageSum)}");

            double percentOfWinTournaments = (countOfWins / numberOfTournaments) * 100;
            Console.WriteLine($"{percentOfWinTournaments:f2}%");
        }
    }
}
