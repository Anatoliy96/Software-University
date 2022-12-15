using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
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

                if (action == "Shoot")
                {
                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);

                    
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        break;
                    }

                    numbers[index] -= power;

                    if (numbers[index] <= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);

                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid placement!");
                        break;
                    }

                    numbers.Insert(index, value);
                    
                }

                else if (action == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);

                    if (index < 0 || index > numbers.Count - 1 || index - radius < 0 || index + radius > numbers.Count - 1)
                    {
                        Console.WriteLine("Strike missed!");
                        break;
                    }

                    numbers.RemoveRange(index - radius, radius * 2 + 1);
                }
            }
            Console.WriteLine(string.Join("|", numbers));
        }
    }
}
