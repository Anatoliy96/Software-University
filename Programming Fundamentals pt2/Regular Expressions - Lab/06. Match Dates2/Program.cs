using System;
using System.Text.RegularExpressions;

namespace _06._Match_Dates2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();

            string pattern = @"(?<days>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(date);

            foreach (Match match in matches)
            {
                var groups = match.Groups;

                Console.WriteLine($"Day: {groups["days"]}, month: {groups["month"]}, year: {groups["year"]}");
            }
        }
    }
}
