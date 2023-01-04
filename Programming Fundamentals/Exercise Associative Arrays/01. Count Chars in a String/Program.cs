using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char ch in text)
            {
                if (ch != ' ')
                {
                    if (!counts.ContainsKey(ch))
                    {
                        counts.Add(ch, 0);
                    }

                    counts[ch]++;
                }
            }

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
