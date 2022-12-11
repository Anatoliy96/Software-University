using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0];

                if (action == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    wagons.Add(number);
                }
                else
                {
                    int passengers = int.Parse(action);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] < capacity)
                        {
                            wagons[i] += passengers;

                            if (wagons[i] > capacity)
                            {
                                wagons[i] -= passengers;
                                continue;
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
