using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double totalGrade = 0;
            int currClass = 1;
            int repeatCount = 0;

            while (currClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrade += grade;

                if (grade < 4)
                {
                    repeatCount++;
                }

                if (repeatCount > 1)
                {
                    break;
                }

                currClass++;
            }
            currClass--;

            if (repeatCount > 1)
            {
                Console.WriteLine($"{name} has been excluded at {currClass} grade");
            }
            else
            {
                double average = totalGrade / (currClass + repeatCount);
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
