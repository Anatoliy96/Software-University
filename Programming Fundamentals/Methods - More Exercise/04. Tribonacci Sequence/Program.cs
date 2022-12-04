using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(num);
        }

        static void PrintTribonacciSequence(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(TribonacciSequence(i) + " ");
            }
        }

        static int TribonacciSequence(int num)
        {
            if (num <= 2) 
            {
                return 1;
            }
            if (num == 3)
            {
                return 2;
            }
            else
            {
                return TribonacciSequence(num - 1) + 
                    TribonacciSequence(num - 2) + 
                    TribonacciSequence(num - 3);
            }
        }
    }
}
