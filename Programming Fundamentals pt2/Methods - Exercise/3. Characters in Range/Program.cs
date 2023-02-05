using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            charInRange(ch1, ch2);
        }

        static void charInRange(char ch1, char ch2)
        {
            int biggestChar = Math.Max(ch1, ch2);
            int smallestChar = Math.Min(ch1, ch2);

            for (int i = smallestChar + 1; i <= biggestChar - 1; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
