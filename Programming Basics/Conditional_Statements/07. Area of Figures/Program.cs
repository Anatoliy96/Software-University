using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double squareArea = a * a;

                Console.WriteLine("{0:f3}", squareArea);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double rectangleArea = a * b;

                Console.WriteLine("{0:f3}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double circleArea = Math.PI * Math.Pow(r, 2);

                Console.WriteLine("{0:f3}", circleArea);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double triangleArea = a * h / 2;

                Console.WriteLine("{0:f3}", triangleArea);
            }
        }
    }
}
