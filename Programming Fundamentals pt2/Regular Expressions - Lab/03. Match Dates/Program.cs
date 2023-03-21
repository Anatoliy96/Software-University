using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            Regex regex = new Regex(pattern);

            MatchCollection result = regex.Matches(input);


            foreach (Match match in result)
            {
                var mathchGroups = match.Groups;
                Console.WriteLine($"Day: {mathchGroups["day"]}, Month: {mathchGroups["month"]}, Year: {mathchGroups["year"]}");
            }
        }
    }
}
