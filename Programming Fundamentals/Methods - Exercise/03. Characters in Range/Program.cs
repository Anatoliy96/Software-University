using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharacterInRange(char1, char2);
        }

        static void CharacterInRange(char char1, char char2)
        {
            char temp = char1;

            if (char2 < char1)
            {
                char1 = char2;
                char2 = temp;
            }

            for (char i = char1; i < char2; i++)
            {
                if (i == char1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}
