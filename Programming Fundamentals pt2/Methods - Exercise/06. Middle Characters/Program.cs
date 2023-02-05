﻿using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string result = PrintMiddleCharacters(text);
            Console.WriteLine(result);
        }

        static string PrintMiddleCharacters(string text)
        {
            int l = 1 - text.Length % 2;
            return text.Substring(text.Length / 2 - l, 1 + l);
        }
    }
}
