using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = 0;


            for (int i = n1; i <= n1; i++)
            {
                if (n2 > 10)
                {
                    result = i * n2;
                    Console.WriteLine($"{i} X {n2} = {result}");
                    break;
                }
                for (int j = n2; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine($"{i} X {j} = {result}");
                }
            }
        }
    }
}
