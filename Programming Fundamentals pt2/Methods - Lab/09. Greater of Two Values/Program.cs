using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(number1, number2));
            }
            else if (type == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(ch1, ch2));
            }
            else if (type == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();

                Console.WriteLine(GetMax(text1, text2));
            }
        }

        static int GetMax(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static char GetMax(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }

        static string GetMax(string text1, string text2)
        {
            if (string.Compare(text1, text2) > 0 )
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}
