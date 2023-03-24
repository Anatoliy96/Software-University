using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {
                string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        string name = match.Groups["name"].Value;
                        string product = match.Groups["product"].Value;
                        int quantity = int.Parse(match.Groups["quantity"].Value);
                        double price = double.Parse(match.Groups["price"].Value);

                        Console.WriteLine($"{name}: {product} - {price * quantity:f2}");

                        totalIncome += price * quantity;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
