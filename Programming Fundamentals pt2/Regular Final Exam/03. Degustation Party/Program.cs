using System;
using System.Collections.Generic;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("-");
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();

            int countOfDislikes = 0;

            while(command[0] != "Stop")
            {
                if (command[0] == "Like")
                {
                    string guest = command[1];
                    string meal = command[2];

                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());

                        guests[guest].Add(meal);
                    }
                    else if (!guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }
                }
                else if (command[0] == "Dislike")
                {
                    string guest = command[1];
                    string meal = command[2];

                    if (!guests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!guests[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        guests[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        countOfDislikes++;
                    }
                }
                command = Console.ReadLine().Split("-");
            }

            foreach (var kvp in guests)
            {
                Console.Write($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {countOfDislikes}");
        }
    }
}
