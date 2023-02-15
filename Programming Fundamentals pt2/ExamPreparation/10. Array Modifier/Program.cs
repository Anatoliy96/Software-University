using System;
using System.Linq;

namespace _10._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int temp = arr[index1];
                    arr[index1] = arr[index2];
                    arr[index2] = temp;
                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    arr[index1] *= arr[index2];
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
