using System;

namespace Loops
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
