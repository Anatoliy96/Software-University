using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = 0;
            double days = 0;
            long hours = 0;
            long minutes = 0;
            years = centuries * 100; 
            days = years * 365.2422;
            hours = (int)days * 24;
            minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {(uint)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
