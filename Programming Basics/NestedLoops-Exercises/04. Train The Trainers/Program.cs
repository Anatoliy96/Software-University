using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfJury = int.Parse(Console.ReadLine());
            string presentationName;
            double averageGradeCurrPresentation = 0;
            double totalAmountOfJury = 0;
            double averageSumOfAllPresentations = 0;

            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                totalAmountOfJury += numberOfJury;

                for (int i = 0; i < numberOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    averageSumOfAllPresentations += grade;
                    averageGradeCurrPresentation += grade;
                }

                Console.WriteLine($"{presentationName} - {averageGradeCurrPresentation / numberOfJury:f2}.");
                averageGradeCurrPresentation = 0;
            }

            Console.WriteLine($"Student's final assessment is {averageSumOfAllPresentations / totalAmountOfJury:f2}.");
        }
    }
}
