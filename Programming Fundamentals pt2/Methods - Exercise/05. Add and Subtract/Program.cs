using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Subtract(a, b, c);

            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Subtract(int a, int b, int c)
        {
            int result = Add(a, b) - c;
            return result;
        }
    }
}
