using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < countOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                string name = command[0];

                if (guests.Contains(name) && command[2] == "going!")
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (guests.Contains(name) && command[2] == "not")
                {
                    guests.Remove(name);
                }
                else if (!guests.Contains(name) && command[2] == "not")
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }

            foreach (var name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
