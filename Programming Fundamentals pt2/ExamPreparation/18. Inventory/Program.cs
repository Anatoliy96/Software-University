using System;
using System.Collections.Generic;
using System.Linq;

namespace _18._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] tokens = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "Craft!")
            {
                string command = tokens[0];
                string item = tokens[1];

                if (command == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }
                else if (tokens[0] == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }
                else if (tokens[0] == "Combine Items")
                {
                    string[] combineItems = item.Split(":");
                    string oldItem = combineItems[0];
                    string newItem = combineItems[1];

                    int index = inventory.IndexOf(oldItem);

                    if (index != -1)
                    {
                        inventory.Insert(index + 1, newItem);
                    }
                }
                else if (tokens[0] == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
                tokens = Console.ReadLine().Split(" - ",StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
