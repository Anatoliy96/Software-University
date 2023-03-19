using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string text = Console.ReadLine().Trim();

            int max = Math.Max(firstChar, secondChar);
            int min = Math.Min(firstChar,secondChar);

            int sum = 0;

            foreach (char ch in text)
            {
                int currentChar = (int)ch;

                if (currentChar > min && currentChar < max)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum); 
        }
    }
}
