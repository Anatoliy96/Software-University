using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> validDestinations = new List<string>();
            string pattern = @"([=|\/])(?<country>[A-Z][A-Za-z]{2,})\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                validDestinations.Add(match.Groups["country"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", validDestinations)}");

            int count = 0;
            foreach (var destination in validDestinations)
            {
                foreach (var ch in destination)
                {
                    count++;
                }
            }

            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
