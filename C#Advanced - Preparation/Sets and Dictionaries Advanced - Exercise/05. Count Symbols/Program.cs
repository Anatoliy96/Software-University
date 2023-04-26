using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            char[] ch = input.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (!charsCount.ContainsKey(ch[i]))
                {
                    charsCount.Add(ch[i], 1);
                }
                else
                {
                    charsCount[ch[i]]++;
                }
            }

            foreach (var c in charsCount)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}
