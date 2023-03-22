using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(",");
            string text = Console.ReadLine();

            Dictionary<string, int> people = new Dictionary<string, int>();

            int sum = 0;
            string result = string.Empty;

            while (text != "end of race")
            {
                string digits = @"(?<digits>[\d+])";
                string letters = @"(?<letters>[A-Za-z+])";

                Regex lettersRegex = new Regex(letters);
                Regex digitsRegex = new Regex(digits);

                MatchCollection letter = lettersRegex.Matches(text);
                MatchCollection digit = digitsRegex.Matches(text);
                
                for (int i = 0; i < letter.Count; i++)
                {
                    result += letter[i];
                }

                foreach (Match match in digit)
                {
                    sum += int.Parse(match.Groups["digits"].Value);
                }

                foreach (var name in command)
                {
                    if (name.Contains(result))
                    {
                        if (!people.ContainsKey(name))
                        {
                            people.Add(name, sum);
                        }
                        else
                        {
                            people[name] += sum;
                        }
                    }
                }

                result = string.Empty;
                sum = 0;

                text = Console.ReadLine();
            }

            var sortedDictonary = people.OrderByDescending(x => x.Value).Take(3);

            Console.WriteLine("1st place: {0}",sortedDictonary.ElementAt(0).Key);
            Console.WriteLine("2nd place:{0}",sortedDictonary.ElementAt(1).Key);
            Console.WriteLine("3rd place:{0}",sortedDictonary.ElementAt(2).Key);

        }
    }
}
