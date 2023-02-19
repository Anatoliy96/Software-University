using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                if (command[0] == "Add")
                {
                    string cardName = command[1];
                    if (!cards.Contains(cardName))
                    {
                        cards.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string cardName = command[1];

                    if (cards.Contains(cardName))
                    {
                        cards.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < cards.Count)
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string cardName = command[2];

                    if (index < 0 || index > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
