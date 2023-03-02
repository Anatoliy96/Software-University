using System;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string studenName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(studenName))
                {
                    grades.Add(studenName, new List<double>());
                }

                grades[studenName].Add(grade);
            }
            double average = 0;
            foreach (var student in grades)
            {
                foreach (var grade in student.Value)
                {
                    average += grade;
                }

                average /= student.Value.Count;

                if (average >= 4.50)
                {
                    averageGrades.Add(student.Key, average);
                }

                average = 0;
            }

            foreach (var student in averageGrades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
