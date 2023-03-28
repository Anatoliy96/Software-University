using System;
using System.Collections.Generic;

namespace _06._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Composer> composers = new Dictionary<string, Composer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                if (!composers.ContainsKey(piece))
                {
                    composers.Add(piece, new Composer());

                    composers[piece].Name = composer;
                    composers[piece].Key = key;
                }
            }

            string[] command = Console.ReadLine().Split("|");

            while (command[0] != "Stop")
            {
                if (command[0] == "Add")
                {
                    string piece = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (!composers.ContainsKey(piece))
                    {
                        composers.Add(piece, new Composer());

                        composers[piece].Name = composer;
                        composers[(piece)].Key = key;

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string piece = command[1];

                    if (composers.ContainsKey(piece))
                    {
                        composers.Remove(piece);

                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];

                    if (composers.ContainsKey(piece))
                    {
                        composers[piece].Key = newKey;

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine().Split("|");
            }

            foreach (var composer in composers)
            {
                Console.WriteLine($"{composer.Key} -> Composer: {composer.Value.Name}, Key: {composer.Value.Key}");
            }
        }

        public class Composer
        {
            public string Name { get; set; }
            public string Key { get; set; }
        }
    }
}
