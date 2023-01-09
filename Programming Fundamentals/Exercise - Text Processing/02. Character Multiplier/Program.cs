using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string text1 = input[0];
            string text2 = input[1];

            int result = SumOfCharacters(text1, text2);
            Console.WriteLine(result);
        }

        public static int SumOfCharacters(string text1, string text2)
        {
            int totalSum = 0;
            string longest = "";
            string shortest = "";

            if (text1.Length > text2.Length)
            {
                longest = text1;
                shortest = text2;
            }
            else
            {
                longest = text2;
                shortest = text1;
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                totalSum += text1[i] * text2[i];
                
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                totalSum += longest[i];
            }
            

            return totalSum;
        }
    }
}
