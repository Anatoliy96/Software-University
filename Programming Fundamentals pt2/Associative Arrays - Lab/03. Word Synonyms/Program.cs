using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (!words.ContainsKey(key))
                {
                    words.Add(key, new List<string>());
                }

                List<string> currentWords = words[key];
                currentWords.Add(value);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
