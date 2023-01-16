using System;

namespace _10._Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = number; i <= number; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sum = i * j;
                    Console.WriteLine($"{i} X {j} = {sum}");
                }
            }
        }
    }
}
