using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, decimal> furnitures = new Dictionary<string, decimal>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                string pattern = @">>(?<name>[A-Z]+[a-z]*( )*[a-z]*)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

                Regex regex = new Regex(pattern);

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    if (!furnitures.ContainsKey(name))
                    {
                        furnitures[name] = 0;
                    }

                    furnitures[name] += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string name in furnitures.Keys)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Total money spend: {0:f2}", furnitures.Values.Sum());
        }
    }
}
