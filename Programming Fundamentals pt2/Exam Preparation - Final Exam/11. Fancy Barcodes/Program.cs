using System;
using System.Text.RegularExpressions;

namespace _11._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string productGroup = string.Empty;

                string pattern = @"[@][#]+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])[@][#]+";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                
                if (match.Success)
                {
                    char[] chars = match.Groups["barcode"].Value.ToCharArray();

                    foreach (var ch in chars)
                    {
                        if (char.IsDigit(ch))
                        {
                            productGroup += ch;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
