using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int sum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];

                    if (sum == givenNumber)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }

                    sum = 0;
                }
            }
        }
    }
}
