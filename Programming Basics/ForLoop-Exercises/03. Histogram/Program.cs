using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            double countOfP1 = 0;
            double countOfP2 = 0;
            double countOfP3 = 0;
            double countOfP4 = 0;
            double countOfP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    countOfP1++;
                }
                else if (numbers >= 200 && numbers < 400)
                {
                    countOfP2++;
                }
                else if (numbers >= 400 && numbers < 600)
                {
                    countOfP3++;
                }
                else if (numbers >= 600 && numbers < 800)
                {
                    countOfP4++;
                }
                else if (numbers >= 800)
                {
                    countOfP5++;
                }
            }

            p1 = countOfP1 / n * 100;
            p2 = countOfP2 / n * 100;
            p3 = countOfP3 / n * 100;
            p4 = countOfP4 / n * 100;
            p5 = countOfP5 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
