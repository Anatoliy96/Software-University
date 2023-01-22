using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger snowBallValue = 0;

            BigInteger max = 0;

            string result = "";

            for (int i = 0; i < n; i++)
            {
                int snowBall = int.Parse(Console.ReadLine());

                int snowBallTime = int.Parse(Console.ReadLine());

                int snowBallQaulity = int.Parse(Console.ReadLine());

                snowBallValue = BigInteger.Pow((snowBall / snowBallTime), snowBallQaulity);

                if (snowBallValue >= max)
                {
                    max = snowBallValue;

                    result = ($"{snowBall} : {snowBallTime} = {snowBallValue} ({snowBallQaulity}");
                }
            }

            Console.WriteLine($"{result})");
        }
    }
}
