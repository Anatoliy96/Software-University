using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> add = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] += 1;
                }
                return arr;
            };
            Func<int[], int[]> multiply = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= 2;
                }

                return arr;
            };

            Func<int[], int[]> subtract = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] -= 1;
                }

                return arr;
            };

            Action<int[]> printer = arr =>
            {
                Console.WriteLine(String.Join(" ", arr));
            };

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    add(input);
                }
                else if (command == "multiply")
                {
                    multiply(input);
                }
                else if (command == "subtract")
                {
                    subtract(input);
                }
                else if (command == "print")
                {
                    printer(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
