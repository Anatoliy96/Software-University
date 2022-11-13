using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currNumber = 1;

            while (currNumber <= n)
            {
                Console.WriteLine(currNumber);
                currNumber = currNumber * 2 + 1;
            }
        }
    }
}
