using System;

namespace _05._Decrypting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            char symbol;
            string result = "";

            for (int i = 1; i <= lines; i++)
            {
                char character = char.Parse(Console.ReadLine());

                symbol = (char)(key + character);
                result = ($"{result + symbol}");
            }

            Console.WriteLine(result);
        }
    }
}
