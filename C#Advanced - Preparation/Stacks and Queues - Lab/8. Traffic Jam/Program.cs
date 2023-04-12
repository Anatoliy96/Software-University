using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> vehicles = new Queue<string>();

            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (vehicles.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{vehicles.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    vehicles.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
