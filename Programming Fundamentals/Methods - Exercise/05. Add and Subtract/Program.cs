using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = SumOfSubtractionOfThirdNumber(n1, n2, n3);
            Console.WriteLine(sum);

        }

        static int SumOfFirstTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        static int SumOfSubtractionOfThirdNumber(int n1, int n2, int n3)
        {
            return SumOfFirstTwoNumbers(n1, n2) - n3;
        }
    }
}
