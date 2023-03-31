using System;
using System.Collections.Generic;

namespace _15._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string[] targets = Console.ReadLine().Split("||");

            while (targets[0] != "Sail")
            {
                string town = targets[0];
                int people = int.Parse(targets[1]);
                int gold = int.Parse(targets[2]);

                if (!cities.ContainsKey(town))
                {
                    cities.Add(town, new City());

                    cities[town].People = people;
                    cities[town].Gold = gold;
                }
                else
                {
                    cities[town].People += people;
                    cities[town].Gold += gold;
                }

                targets = Console.ReadLine().Split("||");
            }

            string[] command = Console.ReadLine().Split("=>");

            while (command[0] != "End")
            {
                if (command[0] == "Plunder")
                {
                    string town = command[1];
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);

                    if (cities.ContainsKey(town))
                    {
                        cities[town].People -= people;
                        cities[town].Gold -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }
                    if (cities[town].People <= 0 || cities[town].Gold <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                    }
                }
                else if (command[0] == "Prosper")
                {
                    string town = command[1];
                    int gold = int.Parse(command[2]);

                    if (cities.ContainsKey(town))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            cities[town].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                        }
                    }
                }
                command = Console.ReadLine().Split("=>");
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var town in cities)
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value.People} citizens, Gold: {town.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        public class City
        {
            public int People { get; set; }
            public int Gold { get; set; }
        }
    }
}
