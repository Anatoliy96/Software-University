﻿using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            string combination = one.ToString() + two.ToString() + three.ToString();

            Console.WriteLine(combination);
        }
    }
}
