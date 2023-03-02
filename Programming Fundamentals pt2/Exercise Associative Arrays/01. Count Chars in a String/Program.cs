using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (char ch in word)
                {
                    if (!counts.ContainsKey(ch))
                    {
                        counts.Add(ch, 1);
                    }
                    else
                    {
                        counts[ch]++;
                    }
                }
            }
            foreach (var ch in counts)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
