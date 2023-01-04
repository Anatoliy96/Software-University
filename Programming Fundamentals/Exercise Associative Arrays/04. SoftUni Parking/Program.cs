using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingTickets = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(' ');
                command = tokens[0];
                
                if (command == "register")
                {
                    string username = tokens[1];
                    string licenseNumber = tokens[2];

                    if (parkingTickets.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                    else
                    {
                        parkingTickets.Add(username, licenseNumber);

                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    string username = tokens[1];

                    if (!parkingTickets.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingTickets.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var people in parkingTickets)
            {
                Console.WriteLine($"{people.Key} => {people.Value}");
            }
        }
    }
}
