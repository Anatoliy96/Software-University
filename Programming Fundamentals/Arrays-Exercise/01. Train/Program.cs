using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int totalPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}" + " ");

                totalPassengers += arr[i];
            }
            Console.WriteLine();

            Console.WriteLine(totalPassengers);
        }
    }
}
