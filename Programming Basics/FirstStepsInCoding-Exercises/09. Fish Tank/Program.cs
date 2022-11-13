using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            int lenght = int.Parse(Console.ReadLine());
            //2.Широчина в см – цяло число в интервала[10 … 300]
            int width = int.Parse(Console.ReadLine());
            //3.Височина в см – цяло число в интервала[10… 200]
            int height = int.Parse(Console.ReadLine());
            //4.Процент – реално число в интервала[0.000 … 100.000]
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;

            double volumeInLiters = volume / 1000;

            double occupiedSpace = percent / 100;

            double neededLiters = volumeInLiters * (1 - occupiedSpace);

            Console.WriteLine(neededLiters);
        }
    }
}
