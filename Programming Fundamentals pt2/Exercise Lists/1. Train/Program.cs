using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command;

            while((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int passengers = int.Parse(tokens[1]);

                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse((tokens[0]));

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity > wagons[i])
                        {
                            wagons[i] += passengers;

                            if (wagons[i] > capacity)
                            {
                                wagons[i] -= passengers;
                                continue;
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
