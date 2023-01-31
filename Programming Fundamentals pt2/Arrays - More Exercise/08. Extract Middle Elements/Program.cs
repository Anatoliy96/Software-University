using System;
using System.Linq;

namespace _08._Extract_Middle_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int middleNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == 1)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
                else if (arr.Length % 2 == 0)
                {
                    middleNumber = arr[arr.Length / 2 - 1];
                    Console.Write($"{middleNumber} ");
                    middleNumber = arr[arr.Length / 2];
                    Console.WriteLine(middleNumber);
                    break;
                }
                else
                {
                    middleNumber = arr[arr.Length / 2 - 1];
                    Console.WriteLine(middleNumber);
                    middleNumber = arr[arr.Length / 2];
                    Console.WriteLine(middleNumber);
                    middleNumber = arr[arr.Length / 2 + 1];
                    Console.WriteLine(middleNumber);
                    break;
                }
            }
        }
    }
}
