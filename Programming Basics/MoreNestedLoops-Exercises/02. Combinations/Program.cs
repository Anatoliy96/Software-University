using System;

namespace _02._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char word1 = char.Parse(Console.ReadLine());
            char word2 = char.Parse(Console.ReadLine());
            char word3 = char.Parse(Console.ReadLine());

            bool isValid = true;
            int combinations = 0;

            for (char i = word1; i <= word2; i++)
            {
                for (char j = word1; j <= word2; j++)
                {
                    for (char k = word1; k <= word2; k++)
                    {
                        if (i == word3 || j == word3 || k == word3)
                        {
                            isValid = false;
                        }

                        if (isValid)
                        {
                            combinations++;
                            Console.Write($"{i}{j}{k} ");
                        }

                        isValid = true;
                    }
                }
            }
            Console.Write(combinations);
        }
    }
}
