using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Add(number);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");

                        command = Console.ReadLine();

                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");

                        command = Console.ReadLine();

                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (tokens[0] == "Shift" && tokens[1] == "left")
                {
                    int count = int.Parse(tokens[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNumber = numbers[i - i];

                        numbers.Remove(firstNumber);
                        numbers.Add(firstNumber);
                    }
                }
                else if (tokens[0] == "Shift" && tokens[1] == "right")
                {
                    int count = int.Parse(tokens[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1];

                        numbers.Remove(lastNumber);
                        numbers.Insert(0, lastNumber);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
