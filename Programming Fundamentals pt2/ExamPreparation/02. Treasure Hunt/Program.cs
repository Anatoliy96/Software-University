using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split("|").ToList();
            List<string> removedTreasure = new List<string>();

            string commands = Console.ReadLine();

            while (commands != "Yohoho!")
            {
                string[] command = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        if (!treasure.Contains(command[i]))
                        {
                            treasure.Insert(0, command[i]);
                        }
                    }
                }
                else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < treasure.Count)
                    {
                        string item = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(item);
                    }
                }
                else if (command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);

                    if (treasure.Count < count)
                    {
                        int itemsToRemove = Math.Min(count, treasure.Count);
                        string[] items = treasure.GetRange(treasure.Count - itemsToRemove, itemsToRemove).ToArray();
                        treasure.RemoveRange(treasure.Count - itemsToRemove, itemsToRemove);

                        Console.WriteLine(String.Join(", ", items));
                    }
                    else
                    {
                        int itemsToRemove = Math.Min(count, treasure.Count);
                        string[] items = treasure.GetRange(treasure.Count - itemsToRemove, itemsToRemove).ToArray();
                        treasure.RemoveRange(treasure.Count - itemsToRemove, itemsToRemove);

                        Console.WriteLine(String.Join(", ", items));
                    }
                }

                commands = Console.ReadLine();
            }

            if (treasure.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double average = 0;

                for (int i = 0; i < treasure.Count; i++)
                {
                    average += treasure[i].Length;
                }

                average /= treasure.Count;

                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
        }
    }
}
