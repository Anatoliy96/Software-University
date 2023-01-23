using System;

namespace _04._Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isTrue = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", i, isTrue.ToString().ToLower());
            }
        }
    }
}
