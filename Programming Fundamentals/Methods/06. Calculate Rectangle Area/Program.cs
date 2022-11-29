using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine(RectAngleArea(lenght, width));
        }

        static int RectAngleArea(int lenght, int width)
        {
            int result = lenght * width;

            return result;
        }
    }
}
