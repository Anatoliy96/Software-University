using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string courseName;

            while ((courseName = Console.ReadLine()) != "end")
            {
                string[] tokens = courseName.Split(" : ");
                courseName = tokens[0];
                string student = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(student);
            }

            foreach (var course in courses)
            {
                string courseNames = course.Key;
                var students = course.Value;

                Console.WriteLine($"{courseNames}: {students.Count}");

                foreach (var studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
