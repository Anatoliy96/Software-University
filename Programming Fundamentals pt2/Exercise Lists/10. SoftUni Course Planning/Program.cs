using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(new char[] {','}).ToList();

            string[] commands = Console.ReadLine().Split(":");
            string command = commands[0];

            while (command != "course start")
            {
                if (command == "Add")
                {
                    string lessonTitle = commands[1];

                    courses.Add(lessonTitle);
                }
                else if (command == "Insert")
                {
                    string lessonTitle = commands[1];
                    int index = int.Parse(commands[2]);

                    courses.Insert(index, lessonTitle);
                }
                else if (command == "Remove")
                {
                    string lessonTitle = commands[1];

                    courses.Remove(lessonTitle);

                    if (courses.Contains($"{lessonTitle}-Exercise"))
                    {
                        courses.Remove($"{lessonTitle}-Exercise");
                    }
                }
                else if (command == "Swap")
                {
                    string firstLessonTitle = commands[1];
                    string secondLessonTitle = commands[2];

                    int firstLessonIndex = courses.FindIndex(l => l.Contains(firstLessonTitle));
                    int secondLessonIndex = courses.FindIndex(l => l.Contains(secondLessonTitle));

                    courses.RemoveAt(firstLessonIndex);
                    courses.RemoveAt(secondLessonIndex - 1);
                    courses.Add(firstLessonTitle);
                    courses.Insert(firstLessonIndex, secondLessonTitle);

                    if (courses.Contains($"{firstLessonTitle}-Exercise"))
                    {
                        int oldExerciseIndex = courses.FindIndex(l => l.Contains($"{firstLessonTitle}-Exercise"));
                        firstLessonIndex = courses.FindIndex(l => l.Contains(firstLessonTitle));
                        courses.Insert(firstLessonIndex + 1, $"{firstLessonTitle}-Exercise");
                        courses.RemoveAt(oldExerciseIndex);
                    }
                    else if (courses.Contains($"{secondLessonTitle}-Exercise"))
                    {
                        int oldExerciseIndex = courses.FindIndex(l => l.Contains($"{secondLessonTitle}-Exercise"));
                        secondLessonIndex = courses.FindIndex(l => l.Contains(secondLessonTitle));
                        courses.Insert(secondLessonIndex + 1, $"{secondLessonTitle}-Exercise");
                        courses.RemoveAt(oldExerciseIndex + 1);
                    }
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = commands[1];

                    if (courses.Contains(lessonTitle))
                    {
                        int index = courses.FindIndex(l => l.Contains(lessonTitle));

                        courses.Insert(index, $"{lessonTitle}-Exercise");
                    }
                    else
                    {
                        courses.Add(lessonTitle);
                        courses.Add($"{lessonTitle}-Exercise");
                    }
                }

                commands = Console.ReadLine().Split(":");
                command = commands[0];
            }

            int count = 1;
            foreach (var course in courses)
            {
                Console.WriteLine($"{count}.{course}");
                
                count++;
            }
        }
    }
}
