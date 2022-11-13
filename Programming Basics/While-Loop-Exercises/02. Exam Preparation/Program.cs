using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBadEvaluations = int.Parse(Console.ReadLine());
            
            int countOfProblems = 0;
            int countOfBadEvaluation = 0;
            double totalGrade = 0;
            double averageGrade = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (countOfBadEvaluation < numberOfBadEvaluations)
            {
                string nameOfTask = Console.ReadLine();

                if ("Enough" == nameOfTask)
                {
                    isFailed = false;
                    break;
                }

                int evaluation = int.Parse(Console.ReadLine());

                if (evaluation <= 4)
                {
                    countOfBadEvaluation++;
                }
                
                totalGrade += evaluation;
                countOfProblems++;
                lastProblem = nameOfTask;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {countOfBadEvaluation} poor grades.");
            }
            else
            {
                averageGrade = totalGrade / countOfProblems;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {countOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
