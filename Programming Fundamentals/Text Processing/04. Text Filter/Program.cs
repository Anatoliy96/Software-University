using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToBan = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var wordToBan in wordsToBan)
            {
                if (text.Contains(wordToBan))
                {
                    text = text.Replace(wordToBan, new string('*', wordToBan.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
