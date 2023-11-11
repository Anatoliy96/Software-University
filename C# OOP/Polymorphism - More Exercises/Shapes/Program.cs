
using Shapes.Models;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(10, 5.5);
            Circle circle = new Circle(7.5);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
