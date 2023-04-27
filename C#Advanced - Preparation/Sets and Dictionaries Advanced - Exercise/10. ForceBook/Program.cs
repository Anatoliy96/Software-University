using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> sides = new Dictionary<string, string>();

            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] splited = command.Split(" | ");

                    string side = splited[0];
                    string name = splited[1];

                    if (!sides.ContainsKey(name))
                    {
                        sides[name] = side;
                    }
                }
                else
                {
                    string[] splited = command.Split(" -> ");
                    string name = splited[0];
                    string side = splited[1];

                    if (sides.ContainsKey(name))
                    {
                        sides[name] = side;
                        
                    }
                    else
                    {
                        sides[name] = side;
                    }
                    Console.WriteLine($"{name} joins the {side} side!");
                }

                command = Console.ReadLine();
            }
            var fillteredSideName = sides
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);

            foreach (var kvp in fillteredSideName)
            {
                string side = kvp.Key;
                var sideNameValue = kvp;

                Console.WriteLine($"Side: {side}, Members: {sideNameValue.Count()}");

                foreach (var kvpValue in sideNameValue.OrderBy(x => x.Key))
                {
                    string name = kvpValue.Key;
                    string side2 = kvpValue.Value;

                    Console.WriteLine($"! {name} ");
                }
            }
        }
    }
}
