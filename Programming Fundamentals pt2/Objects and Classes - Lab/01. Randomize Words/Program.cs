using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random random = new Random();

            int rnd = random.Next(0, words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                words[i] = words[rnd];
                words[rnd] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
