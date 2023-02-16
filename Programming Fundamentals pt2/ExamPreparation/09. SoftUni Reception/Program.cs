using System;

namespace _09._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());

            int countOfStundets = int.Parse(Console.ReadLine());

            int hourCount = 1;

            int employeesEfficiency = emp1 + emp2 + emp3;

            while (countOfStundets > 0)
            {
                if (hourCount % 4 == 0)
                {
                    hourCount++;
                    continue;
                }

                countOfStundets -= employeesEfficiency;

                if (countOfStundets <= 0)
                {
                    break;
                }

                hourCount++;
            }

            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}
