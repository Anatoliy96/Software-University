using System;
using System.Collections.Generic;

namespace _05._CitiesByContinentAndCountry
{
    internal class Program
    {
        public static object Dictrionary { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> kvp = new Dictionary<string, Dictionary<string,List<string>>>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!kvp.ContainsKey(continent))
                {
                    kvp.Add(continent, new Dictionary<string, List<string>>());

                    if (!kvp[continent].ContainsKey(country))
                    {
                        kvp[continent].Add(country, new List<string>());
                    }

                    kvp[continent][country].Add(city);
                }
                else
                {
                    if (!kvp[continent].ContainsKey(country))
                    {
                        kvp[continent].Add(country, new List<string>());
                    }

                    kvp[continent][country].Add(city);
                }
            }
            foreach (var continentKey in kvp)
            {
                Console.WriteLine($"{continentKey.Key}:");

                foreach (var countryKey in continentKey.Value)
                {
                    Console.WriteLine($"{countryKey.Key} -> {string.Join(", ", countryKey.Value)}");
                }
            }
        }
    }
}
