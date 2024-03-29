﻿using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < numberOfMessages; i++)
            {
                Random rnd = new Random();

                int randomIndexPhrases = rnd.Next(0, phrases.Length);
                int randomIndexEvents = rnd.Next(0, events.Length);
                int randomIndexAuthors = rnd.Next(0, authors.Length);
                int randomIndexCities = rnd.Next(0, cities.Length);
                phrases[i] = phrases[randomIndexPhrases];
                events[i] = events[randomIndexEvents];
                authors[i] = authors[randomIndexAuthors];
                cities[i] = cities[randomIndexCities];

                Console.WriteLine($"{phrases[i]} {events[i]} {authors[i]} – {cities[i]}.");
            }
        }
    }
}
