using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[color][clothes[j]]++;
                        }
                    }
                }
            }

            string[] clothsToFound = Console.ReadLine().Split(' ');

            string colorInWardrobe = clothsToFound[0];
            string clothInWardrobe = clothsToFound[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key}clothes:");

                foreach (var cloth in color.Value)
                {
                    if (color.Key.Contains(colorInWardrobe) && cloth.Key.Contains(clothInWardrobe))
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }
            }
        }
    }
}
