using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double sumFromTickets = tickets * priceOfTicket;
            double income = days * sumFromTickets;
            double percentForCinema = income * (percent / 100.0);
            double totalIncome = income - percentForCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {totalIncome:f2} lv.");
        }
    }
}
