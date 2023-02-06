using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int giveIndex = int.Parse(command[1]);
                    arr = ExchangeArr(arr, giveIndex);
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMinMax(arr, command[0], command[1]);
                }
                else
                {
                    FindNumbers(arr, command[0], int.Parse(command[1]), command[2]);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void FindNumbers(int[] arr, string position, int numbersCount, string evenOdd)
        {
            if (numbersCount > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (numbersCount == 0)
            {
                Console.WriteLine($"[]");
                return;
            }

            int resultEvenOdd = 1;
            if (evenOdd == "even") resultEvenOdd = 0;
            int count = 0;
            List<int> nums = new List<int>();

            if (position == "first")
            {
                foreach (int currNumber in arr)
                {
                    if (currNumber % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(currNumber);
                    }
                    if (count == numbersCount)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int currIndex = 0; currIndex < arr.Length; currIndex++)
                {
                    if (arr[currIndex] % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(arr[currIndex]);
                    }
                    if (count == numbersCount)
                    {
                        break;
                    }
                }
                nums.Reverse();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void FindMinMax(int[] arr, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;
            int resultOddEven = 1;

            if (evenOrOdd == "even") resultOddEven = 0;

            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
            {
                if (arr[currIndex] % 2 == resultOddEven)
                {
                    if (minOrMax == "min" && min >= arr[currIndex])
                    {
                        min = arr[currIndex];
                        index = currIndex;
                    }
                    else if (minOrMax == "max" && max <= arr[currIndex])
                    {
                        max = arr[currIndex];
                        index = currIndex;
                    }
                }
            }

            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
        }

        private static int[] ExchangeArr(int[] arr, int splitIndex)
        {
            if (splitIndex >= arr.Length || arr.Length < 0)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] exchangeArray = new int[arr.Length];

            int index = 0;

            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                exchangeArray[index] = arr[i];
                index++;
            }

            for (int i = 0; i <= splitIndex; i++)
            {
                exchangeArray[index] = arr[i];
                index++;
            }

            return exchangeArray;
        }
    }
}
