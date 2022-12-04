using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int number = int.Parse(Console.ReadLine());
                int result = ReturnInt(number);

                Console.WriteLine(result);
            }
            else if (command == "real")
            {
                double number = double.Parse(Console.ReadLine());
                double result = ReturnDouble(number);

                Console.WriteLine($"{result:f2}");
            }
            else if (command == "string")
            {
                string text = Console.ReadLine();
                string result = ReturnString(text);

                Console.WriteLine($"${text}$");
            }
        }

        static int ReturnInt(int number)
        {
            return number *= 2;
        }

        static double ReturnDouble(double number)
        {
            return number *= 1.5;
        }

        static string ReturnString(string text)
        {
            return text;
        }
    }
}
