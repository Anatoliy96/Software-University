using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int[] warshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int maximumHealth = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Retire")
            {
                if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);

                    if (index >= 0 && index < warshipStatus.Length)
                    {
                        warshipStatus[index] -= damage;

                        if (warshipStatus[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (startIndex >= 0 && startIndex < pirateShipStatus.Length && endIndex >= 0 && endIndex < pirateShipStatus.Length)
                        {
                            pirateShipStatus[i] -= damage;

                            if (pirateShipStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);

                    if (index >= 0 && index < pirateShipStatus.Length)
                    {
                        pirateShipStatus[index] += health;

                        if (pirateShipStatus[index] > maximumHealth)
                        {
                            pirateShipStatus[index] = maximumHealth;
                        }
                    }
                }
                else if (command[0] == "Status") 
                {
                    int count = 0;

                    for (int i = 0; i < pirateShipStatus.Length; i++)
                    {
                        double healthPercentige = maximumHealth * 0.20;

                        if (pirateShipStatus[i] < healthPercentige)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }

                command = Console.ReadLine().Split(); 
            }

            Console.WriteLine($"Pirate ship status: {pirateShipStatus.Sum()}");
            Console.WriteLine($"Warship status: {warshipStatus.Sum()}");
        }
    }
}

