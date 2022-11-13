using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            string word = "";
            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                string symbol = command;


                word += symbol;
                
            }
        }
    }
}
