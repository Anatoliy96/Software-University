          using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            foreach (char ch in input)
            {
                char shifted = (char)(ch + 3);
                result += shifted;
            }
            Console.WriteLine(result);
        }
    }
}
