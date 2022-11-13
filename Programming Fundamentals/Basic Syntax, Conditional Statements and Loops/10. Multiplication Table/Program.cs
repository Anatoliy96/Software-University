using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = n; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine($"{i} X {j} = {result}");
                }
            }
        }
    }
}
