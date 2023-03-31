using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> emojis = new List<string>();

            int coolThreshold = 1;
            string pattern = @"([:]{2}|[\*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string digitsPattern = @"(?<digits>[\d])";

            Regex regex = new Regex(pattern);
            Regex digits = new Regex(digitsPattern);

            MatchCollection emoji = regex.Matches(input);
            MatchCollection digitsMatches = digits.Matches(input);

            foreach (Match match in digitsMatches)
            {
                coolThreshold *= int.Parse(match.Groups["digits"].Value);
            }

            foreach (Match match in emoji)
            {
                char[] chars = match.Groups["emoji"].Value.ToCharArray();
                int sum = 0;

                foreach (var ch in chars)
                {
                    sum += ch;
                }

                if (sum > coolThreshold)
                {
                    emojis.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");
            foreach (var emo in emojis)
            {
                Console.WriteLine(emo);
            }
        }
    }
}
