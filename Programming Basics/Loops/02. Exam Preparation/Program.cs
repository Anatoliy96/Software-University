using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            string taskName;

            double totalScore = 0;
            int numberOfProblems = 0;
            int badEvaluations = 0;
            string lastProblem = "";

            while ((taskName = Console.ReadLine()) != "Enough")
            {
                int evaluation = int.Parse(Console.ReadLine());

                numberOfProblems++;

                totalScore += evaluation;

                if (evaluation <= 4)
                {
                    badEvaluations++;
                }
                if (badEvaluations >= failedThreshold)
                {
                    Console.WriteLine($"You need a break, {badEvaluations} poor grades.");
                    return;
                }
                lastProblem = taskName;
            }
                double average = totalScore / numberOfProblems;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
