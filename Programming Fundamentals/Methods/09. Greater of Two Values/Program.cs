

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
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                GetMax(num1, num2);
            }
            else if (type == "char")
            {
                char character1 = char.Parse(Console.ReadLine());
                char character2 = char.Parse(Console.ReadLine());

                GetMax(character1, character2);
            }
            else if (type == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();

                GetMax(text1, text2);
            }
        }

        static void GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }

        static void GetMax(char character1, char character2)
        {
            if (character1 > character2)
            {
                Console.WriteLine(character1);
            }
            else
            {
                Console.WriteLine(character2);
            }
        }

        static void GetMax(string text1, string text2)
        {
            int result = text1.CompareTo(text2);

            if (result > 0)
            {
                Console.WriteLine(text1);
            }
            else if (result < 0)
            {
                Console.WriteLine(text2);
            }
        }
    }
}
