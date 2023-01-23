using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int intValue;
            float floatValue;
            bool boolValue;
            char charValue;

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
