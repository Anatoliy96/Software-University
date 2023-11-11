using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get => height;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero");
                }

                height = value;
            }
        }
        public double Width
        {
            get => width;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero");
                }

                width = value;
            }
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return Height + Height + Width + Width;
        }

        public override string Draw()
        {
            return base.Draw() + $" {typeof(Rectangle).Name}";
        }
    }
}
