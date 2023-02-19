using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine().Split(", ").ToArray();
            int blackListedCount = 0;
            int countOfLostNames = 0;

            string[] command = Console.ReadLine().Split();
            
            while(command[0] != "Report")
            {
                if (command[0] == "Blacklist")
                {
                    string name = command[1];

                    if (friends.Contains(name))
                    {
                        string blackListedName = name;
                        int index = Array.IndexOf(friends, name);
                        friends[index] = "Blacklisted";
                        Console.WriteLine($"{blackListedName} was blacklisted.");
                        blackListedCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command[0] == "Error")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < friends.Length && !friends[index].Contains("Blacklisted") && !friends[index].Contains("Lost"))
                    {
                        string lostName = friends[index];
                        friends[index] = "Lost";
                        countOfLostNames++;
                        Console.WriteLine($"{lostName} was lost due to an error.");
                    }
                }
                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    string newName = command[2];

                    if (index >= 0 && index < friends.Length)
                    {
                        string oldName = friends[index];
                        friends[index] = newName;

                        Console.WriteLine($"{oldName} changed his username to {friends[index]}.");
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Blacklisted names: {blackListedCount}");
            Console.WriteLine($"Lost names: {countOfLostNames}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
