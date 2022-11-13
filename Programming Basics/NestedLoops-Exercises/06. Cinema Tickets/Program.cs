using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName;
            string typeOfTicket;

            double countOfStandartTickets = 0;
            double countOfStudentTickets = 0;
            double countOfKidTickets = 0;
            double countOfTotalTickets = 0;

            while ((movieName = Console.ReadLine()) != "Finish")
            {
                int emptySpace = int.Parse(Console.ReadLine());
                int numberOfTickets = 0;

                while (emptySpace > numberOfTickets && (typeOfTicket = Console.ReadLine()) != "End")
                {
                    numberOfTickets++;

                    if (typeOfTicket == "standard")
                    {
                        countOfStandartTickets++;
                    }
                    else if (typeOfTicket == "student")
                    {
                        countOfStudentTickets++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        countOfKidTickets++;
                    }

                    countOfTotalTickets++;
                }
                Console.WriteLine($"{movieName} - {numberOfTickets * 100.00 / emptySpace:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {countOfTotalTickets}");
            Console.WriteLine($"{countOfStudentTickets * 100 / countOfTotalTickets:f2}% student tickets.");
            Console.WriteLine($"{countOfStandartTickets * 100 / countOfTotalTickets:f2}% standard tickets.");
            Console.WriteLine($"{countOfKidTickets * 100 / countOfTotalTickets:f2}% kids tickets.");
        }
    }
}
