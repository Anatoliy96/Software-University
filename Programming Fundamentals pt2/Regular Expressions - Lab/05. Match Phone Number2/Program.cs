using System;
using System.Text.RegularExpressions;

namespace _05._Match_Phone_Number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();

            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}";

            Regex result = new Regex(pattern);

            MatchCollection matches = result.Matches(phoneNumbers);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
