using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] bottlesCapacity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(bottlesCapacity);

            int wastedWater = 0;
            
            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    wastedWater += bottles.Peek() - cups.Peek();
                    bottles.Pop();
                    cups.Dequeue();
                }
                else if (cups.Peek() > bottles.Peek())
                {
                    int cup = cups.Peek();

                    while (cup > 0)
                    {
                        cup -= bottles.Peek();
                        if (cup <= 0 && bottles.Peek() > 0)
                        {
                            wastedWater += Math.Abs(cup);
                        }
                        bottles.Pop();
                    }
                    cups.Dequeue();
                }
            }

            if (cups.Count == 0 && bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
