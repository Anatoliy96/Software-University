﻿using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < messages; i++)
            {
                Random random = new Random();

                int indexPhases = random.Next(0, phrases.Length);
                int indexEvents = random.Next(0, events.Length);
                int indexAuthors = random.Next(0, authors.Length);
                int indexCities = random.Next(0, cities.Length);

                string rndPhase = phrases[indexPhases];
                string rndEvents = events[indexEvents];
                string rndAuthors = authors[indexAuthors];
                string rndCities = cities[indexCities];

                Console.WriteLine($"{rndPhase} {rndEvents} {rndAuthors} – {rndCities}.");
            }
        }
    }
}
