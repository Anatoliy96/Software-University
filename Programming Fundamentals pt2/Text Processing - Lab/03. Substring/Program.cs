﻿using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordToRemove))
            {
                int index = text.IndexOf(wordToRemove);

                text = text.Remove(index, wordToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}
