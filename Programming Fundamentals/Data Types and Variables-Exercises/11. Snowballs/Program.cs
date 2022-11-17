using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger max = 0;
            BigInteger snowballValue = 0;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= max)
                {
                    max = snowballValue;
                    result = ($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
                }
            }
            Console.WriteLine(result);
        }
    }
}
