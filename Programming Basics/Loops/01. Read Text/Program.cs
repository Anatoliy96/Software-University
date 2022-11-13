using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            while ((name = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(name);
            }
        }
    }
}
