using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayofWeek = Console.ReadLine();

            int ticketPrice = 0;

            if (dayofWeek == "Monday" || dayofWeek == "Tuesday" || dayofWeek == "Friday")
            {
                ticketPrice += 12;
            }
            
            else if (dayofWeek == "Wednesday" || dayofWeek == "Thursday")
            {
                ticketPrice += 14;
            }
            else if (dayofWeek == "Saturday" || dayofWeek == "Sunday")
            {
                ticketPrice += 16;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
