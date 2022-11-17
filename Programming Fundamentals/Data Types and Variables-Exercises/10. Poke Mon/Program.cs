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

            int counter = 0;
            double percent = n * 0.5;
            while (n >= m)
            {
                n -= m;

                counter++;

                if (n == percent && y != 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
