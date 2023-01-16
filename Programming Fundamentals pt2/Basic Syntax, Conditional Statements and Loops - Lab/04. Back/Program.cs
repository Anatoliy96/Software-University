using System;

namespace _04._Back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeAfterMinutes = minutes + 30;
            int timeAfterHours = hours + 30;
            if (timeAfterMinutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            else if (timeAfterHours > 23)
            {

            }
        }
    }
}
