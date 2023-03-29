using System;
using System.Text.RegularExpressions;

namespace _07._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int calories = 0;
            int caloriesPerDay = 2000;

            string pattern = @"(\||#)(?<product>[A-Za-z\s]+)\1(?<date>\d{2}[\/]\d{2}[\/]\d{2})\1(?<calories>\d+)\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                calories += int.Parse(match.Groups["calories"].Value);
            }

            int days = calories / caloriesPerDay;
           
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["product"].Value}, Best before: {match.Groups["date"].Value}, " +
                    $"Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
