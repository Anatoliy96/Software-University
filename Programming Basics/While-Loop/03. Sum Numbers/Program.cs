using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < number)
            {
                int currNumber = int.Parse(Console.ReadLine());

                sum += currNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
