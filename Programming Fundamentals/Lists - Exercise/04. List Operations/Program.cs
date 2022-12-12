using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                if (action == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Add(number);
                }

                else if (action == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }

                else if (action == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                    numbers.RemoveAt(index);
                }

                else if (action == "Shift")
                {
                    int count = int.Parse(tokens[2]);

                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
