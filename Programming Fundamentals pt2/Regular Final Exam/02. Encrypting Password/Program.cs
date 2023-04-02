using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"(.+)(\>)(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^\<\>]{3})(\<)\1";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string numbers = match.Groups[3].Value;
                    string lowercase = match.Groups[4].Value;
                    string uppercase = match.Groups[5].Value;
                    string other = match.Groups[6].Value;

                    string password = numbers + lowercase + uppercase + other;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
