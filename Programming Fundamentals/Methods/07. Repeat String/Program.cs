using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            RepeatingText(someText, repeatCount);
        }

        static string RepeatingText(string someText, int repeatCount)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.Write(someText);
            }
            return someText;
        }
    }
}
