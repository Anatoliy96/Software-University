using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfNight = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || 
                dayOfWeek == "Friday" || dayOfWeek == "Saturday")
            {
                if (hourOfNight >= 10 && hourOfNight <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}
