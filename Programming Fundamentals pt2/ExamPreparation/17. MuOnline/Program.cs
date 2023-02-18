using System;
using System.Linq;

namespace _17._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] roomsInDungeons = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int currentHealth = 100;
            int bitcoins = 0;
            bool isDead = false;
            int roomsCount = 0;
            int damageTaken = 0;

            foreach (var room in roomsInDungeons)
            {
                string[] parts = room.Split();
                string command = parts[0];
                int amount = int.Parse(parts[1]);

                roomsCount++;

                if (command == "potion")
                {
                    currentHealth += amount;

                    if (currentHealth > 100)
                    {
                        currentHealth = 100;
                        Console.WriteLine($"You healed for {damageTaken} hp.");
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                    
                }
                else if (command == "chest")
                {
                    bitcoins += amount;

                    Console.WriteLine($"You found {amount} bitcoins.");
                    
                }
                else
                {
                    currentHealth -= amount;
                    damageTaken = amount;

                    if (currentHealth <= 0)
                    {
                        isDead = true;
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }
            }

            if (!isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {currentHealth}");
            }

        }
    }
}
