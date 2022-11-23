using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =
                Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int diffrence = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }

            diffrence = evenSum - oddSum;

            Console.WriteLine(diffrence);
        }
    }
}
