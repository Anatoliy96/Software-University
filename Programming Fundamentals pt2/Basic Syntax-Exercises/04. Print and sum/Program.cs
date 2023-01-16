using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += i;

                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
