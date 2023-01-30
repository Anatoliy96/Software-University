using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] words = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'a' || word[j] == 'e' || word[j] == 'i' || word[j] == 'o' || word[j] == 'u' ||
                        word[j] == 'A' || word[j] == 'E' || word[j] == 'I' || word[j] == 'O' || word[j] == 'U')
                    {
                        sum += word[j] * word.Length;
                    }
                    else
                    {
                        sum += word[j] / word.Length;
                    }
                }

                words[i] = sum;
                sum = 0;
            }
            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
