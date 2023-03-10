using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder chars = new StringBuilder();

            foreach (var ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letter.Append(ch);
                }
                else
                {
                    chars.Append(ch);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letter);
            Console.WriteLine(chars);
        }
    }
}
