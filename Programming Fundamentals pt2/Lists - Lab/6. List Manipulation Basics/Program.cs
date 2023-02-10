using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Add(number);
                }
                else if (tokens[0] == "Remove")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Remove(number);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);

                    numbers.RemoveAt(index);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    numbers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
