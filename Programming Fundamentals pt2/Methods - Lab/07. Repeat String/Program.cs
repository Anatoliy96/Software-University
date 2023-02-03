using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, repeat));
        }

        static string RepeatString(string text, int times) 
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += text; 
            }

            return result;
        }
    }
}
