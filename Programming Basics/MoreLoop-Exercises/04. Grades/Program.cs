using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double betweenTwoOrLessThanThree = 0;
            double betweenThreeOrLessThanFour = 0;
            double betweenFourOrLessThanFive = 0;
            double moreThanFive = 0;
            double totalGrade = 0;
            double average = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                totalGrade += grade;

                if (grade < 3.00)
                {
                    betweenTwoOrLessThanThree++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    betweenThreeOrLessThanFour++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    betweenFourOrLessThanFive++;
                }
                else if (grade >= 5.00)
                {
                    moreThanFive++;
                }
            }

            Console.WriteLine($"Top students: {moreThanFive * 100 / numberOfStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betweenFourOrLessThanFive * 100 / numberOfStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {betweenThreeOrLessThanFour * 100 / numberOfStudents:f2}%");
            Console.WriteLine($"Fail: {betweenTwoOrLessThanThree * 100 / numberOfStudents:f2}%");
            Console.WriteLine($"Average: {totalGrade / numberOfStudents:f2}");
        }
    }
}
