using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int bonusTime = 15;

            minutes = minutes + bonusTime;

            if (minutes > 59)
            {
                hour = hour + 1;

                if (hour > 23)
                {
                    hour = 0;
                }
                minutes -= 60;
            }
            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
