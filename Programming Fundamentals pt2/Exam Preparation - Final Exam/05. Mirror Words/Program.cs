using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"([@|#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);

            Dictionary<string, string> result = new Dictionary<string, string>();
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string wordOne = match.Groups["first"].Value;
                string wordTwo = match.Groups["second"].Value;

                string secondReversed = string.Join("", wordTwo.ToCharArray().Reverse().ToArray());

                if (wordOne == secondReversed)
                {
                    result.Add(wordOne, wordTwo);
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }

            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }

            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", result.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}
