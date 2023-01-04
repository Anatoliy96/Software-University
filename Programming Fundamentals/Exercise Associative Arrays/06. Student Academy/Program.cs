using System;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> averageGrades = new Dictionary<string, double>();
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(studentName))
                {
                    grades.Add(studentName, new List<double>());
                    averageGrades.Add(studentName, grade);
                }

                grades[studentName].Add(grade);

                foreach (var student in grades.Values)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
