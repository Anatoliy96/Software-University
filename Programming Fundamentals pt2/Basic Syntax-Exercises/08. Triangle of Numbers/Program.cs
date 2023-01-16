using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= number; rows++)
            {
                for (int colums = 1; colums <= rows; colums++)
                {
                    Console.Write(rows + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
