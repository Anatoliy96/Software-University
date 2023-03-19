using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string text = Console.ReadLine();
            string result = string.Empty;
            while (text != "find")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int keyIndex = 0;
                    int currentChar = text[i] - keys[keyIndex];
                    keyIndex = (keyIndex + 1) % keys.Length;
                    result += (char)currentChar;
                }

                text = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
