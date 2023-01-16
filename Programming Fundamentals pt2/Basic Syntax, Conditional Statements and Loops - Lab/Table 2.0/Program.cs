using System;

namespace Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = number; i <= number; i++)
            {
                if (times > 10)
                {
                    sum = i * times;
                    Console.WriteLine($"{i} X {times} = {sum}");
                    break;
                }
                for (int j = times; j <= 10; j++)
                {
                    sum = i * j;
                    Console.WriteLine($"{i} X {j} = {sum}");
                }
            }
        }
    }
}
