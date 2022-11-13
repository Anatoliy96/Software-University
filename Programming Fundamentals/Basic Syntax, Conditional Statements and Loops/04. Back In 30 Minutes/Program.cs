using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var time = new TimeSpan(hours, minutes + 30, 0);
            Console.WriteLine($"{time:h\\:mm}");
        }
    }
}
