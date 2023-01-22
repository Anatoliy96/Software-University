using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targetsPoket = 0;
            double percent = n * 0.5;

            while (n >= m)
            {
                n -= m;

                targetsPoket++;

                if (n == percent && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsPoket);
        }
    }
}
