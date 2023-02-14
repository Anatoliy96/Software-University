using System;
using System.Linq;

namespace _05._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();
            int shots = 0;

            while (command[0] != "End")
            {
                int index = int.Parse(command[0]);
                int element = 0;

                if (index >= 0 && index < targets.Length) 
                {
                    element = targets[index];

                    targets[index] = -1;

                    shots++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > 0 && targets[i] > element)
                        {
                            targets[i] -= element;
                        }
                        else if (targets[i] > 0 && targets[i] <= element)
                        {
                            targets[i] += element;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Shot targets: {shots} -> {string.Join(" ", targets)}");
        }
    }
}
