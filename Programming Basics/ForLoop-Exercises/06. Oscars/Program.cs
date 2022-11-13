using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string nameOfAccesor = Console.ReadLine();
                double pointsOfAccesor = double.Parse(Console.ReadLine());

                points = points + ((nameOfAccesor.Length * pointsOfAccesor) / 2);

                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points < 1250.5)
            {
                double pointsNeeded = 1250.5 - points;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
