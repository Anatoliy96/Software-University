using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(' ');
                string firsName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student();

                student.FirstName = firsName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);
            }
            string city = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
