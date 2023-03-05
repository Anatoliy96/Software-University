using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> std = new List<Student>();


            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] students = Console.ReadLine().Split(" ");
                string firstName = students[0];
                string lastName = students[1];
                double grade = double.Parse(students[2]);

                Student student = new Student(firstName, lastName, grade);

                std.Add(student);
            }

            std = std.OrderByDescending(s => s.Grade).ToList();

            foreach (var student in std)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        public class Student
        {
            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
    }
}
