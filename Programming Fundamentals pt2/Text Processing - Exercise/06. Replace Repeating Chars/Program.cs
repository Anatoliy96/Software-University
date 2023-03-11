using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char ch = input[0];

            Console.Write(ch);

            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (ch != currentChar)
                {
                    ch = currentChar;
                    Console.Write(ch);
                }
            }
        }
    }
}
