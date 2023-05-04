using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');

            Action<string> action = PrintNames(names);
        }

        private static Action<string> PrintNames(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            return null;
        }
    }
}
