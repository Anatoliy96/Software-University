using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string name = Console.ReadLine();

                string[] tokens = name.Split();

                if (tokens[1] == "is" && tokens[2] == "going!")
                {
                    if (!guests.Contains(tokens[0]))
                    {
                        guests.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (tokens[1] == "is" && tokens[2] == "not" && tokens[3] == "going!")
                {
                    if (guests.Contains(tokens[0]))
                    {
                        guests.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
