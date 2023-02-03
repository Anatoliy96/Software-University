using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            RectAngleArea(width, height);
        }

        static void RectAngleArea(int width, int height)
        {
            Console.WriteLine(width * height);
        }
    }
}
