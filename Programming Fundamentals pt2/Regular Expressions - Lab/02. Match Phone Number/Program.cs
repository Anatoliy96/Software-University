using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            MatchCollection result = Regex.Matches(input, pattern);

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
