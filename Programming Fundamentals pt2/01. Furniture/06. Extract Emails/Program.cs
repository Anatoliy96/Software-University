using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\s\b[a-zA-Z\d]+([-._][a-zA-Z\d]+)*[@][a-zA-z]+([-][a-zA-z]+)*([.]([a-zA-z]+([-][a-zA-z]+)*))+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value}");
            }
        }
    }
}
