using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int largeArray = Math.Max(arr1.Length, arr2.Length);

            int[] arr3 = new int[largeArray];

            for (int i = 0; i < largeArray; i++)
            {
                arr3[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}
