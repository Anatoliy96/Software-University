using System;
using System.Text.RegularExpressions;

namespace _04_Match_Full_Name2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            Console.Write(string.Join(" ", matches));
            
            Console.WriteLine();
        }
    }
}
