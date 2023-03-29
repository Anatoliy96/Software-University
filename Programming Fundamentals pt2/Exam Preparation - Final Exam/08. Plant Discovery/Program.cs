using System;
using System.Collections.Generic;

namespace _08._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new Plant());
                    plants[plant].Rarity = rarity;
                    plants[plant].Raitings = new List<int>();
                }
                else
                {
                    plants[plant].Rarity = rarity;
                }
            }

            string[] command = Console.ReadLine().Split(new string[] { " ", ":" ,"-" },StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Exhibition")
            {
                if (command[0] == "Rate")
                {
                    string plant = command[1];
                    int raiting = int.Parse(command[2]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Raitings.Add(raiting);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Update")
                {
                    string plant = command[1];
                    int newRarity = int.Parse(command[2]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset")
                {
                    string plant = command[1];

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Raitings.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine().Split(new string[] { " ", ":", "-" }, StringSplitOptions.RemoveEmptyEntries);
            }

            double sum = 0;

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                foreach (var raiting in plant.Value.Raitings)
                {
                    sum += raiting;
                }
                double average = sum / plant.Value.Raitings.Count;

                if (Double.IsNaN(average))
                {
                    average = 0;
                }

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {average:f2}");

                sum = 0;
                average = 0;
            }
        }

        public class Plant
        {
            public int Rarity { get; set; }
            public List<int> Raitings { get; set; }
        }
    }
}
