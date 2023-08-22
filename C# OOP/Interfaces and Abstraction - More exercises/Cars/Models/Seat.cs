using Cars.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get => model; private set => model = value; }
        public string Color { get => color; private set => color = value; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
