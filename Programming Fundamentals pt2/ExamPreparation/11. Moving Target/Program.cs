using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Shoot")
                {
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int radius = int.Parse(command[2]);

                    if (index < 0 || index > targets.Count || index - radius < 0 || index + radius > targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        command = Console.ReadLine().Split();

                        continue;
                    }

                    targets.RemoveRange(index - radius, radius * 2 + 1);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join("|", targets));
        }
    }
}
