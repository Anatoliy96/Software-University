using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 1);
                }
                else
                {
                    counts[wordInLowerCase]++;
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key}" + " ");
                }
            }
        }
    }
}
