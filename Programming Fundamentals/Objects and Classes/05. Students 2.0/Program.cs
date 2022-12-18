using System;
using System.Collections.Generic;

namespace _05._Students_2._0
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
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student();

                if (IsStudentExist(students, firstName, lastName))
                {

                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    students.Add(student);
                }

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student existingStudent = GetStudent(students, firstName, lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
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

        public static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        public static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
