using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversedTxt = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedTxt += text[i];
            }

            Console.WriteLine(reversedTxt);
        }
    }
}
