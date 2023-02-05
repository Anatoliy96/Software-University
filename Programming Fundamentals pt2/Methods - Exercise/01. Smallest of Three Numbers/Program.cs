using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = SmallestNumber(a, b, c);
            Console.WriteLine(result);
        }

        static int SmallestNumber(int a, int b, int c)
        {
            int result = 0;

            if (a <= b && a <= c)
            {
                result = a;
            }
            else if (b <= a && b <= c)
            {
                result = b;
            }
            else if (c <= a && c <= b)
            {
                result = c;
            }

            return result;
        }
    }
}
