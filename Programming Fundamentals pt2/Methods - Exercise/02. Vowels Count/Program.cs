using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int count = 0;

            int result = CountVowels(text, count);

            Console.WriteLine(result);
        }

        static int CountVowels(string text, int count)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString().Contains("a") || text[i].ToString().Contains("e") || text[i].ToString().Contains("i") 
                    || text[i].ToString().Contains("o") || text[i].ToString().Contains("u") || text[i].ToString().Contains("A")
                    || text[i].ToString().Contains("E") || text[i].ToString().Contains("I") || text[i].ToString().Contains("O")
                    || text[i].ToString().Contains("U"))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
