using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        public static object Dictionaty { get; private set; }

        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ",StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);

                command = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var stundent in kvp.Value)
                {
                    Console.WriteLine($"-- {stundent}");
                }
            }
        }
    }
}
