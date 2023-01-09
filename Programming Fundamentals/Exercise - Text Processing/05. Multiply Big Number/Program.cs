using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reallyBigInt = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = reallyBigInt.Length - 1; i >= 0; i--)
            {
                char lastChar = reallyBigInt[i];
                int lastNum = int.Parse(lastChar.ToString());

                int result = lastNum * number + remainder;

                sb.Append(lastChar % 10);

                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder reversedSb = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversedSb.Append(sb[i]);
            }

            Console.WriteLine(reversedSb);
        }
    }
}
