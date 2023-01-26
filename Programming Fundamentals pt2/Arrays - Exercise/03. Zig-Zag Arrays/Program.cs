using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] arr1 = new int[rows];
            int[] arr2 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr1[i] = numbers[1];
                    arr2[i] = numbers[0];
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
