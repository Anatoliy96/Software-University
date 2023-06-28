using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            this.model = model;
            this.color = color;
            this.battery = battery;

        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }

        public int Battery
        {
            get { return battery; }
            private set { battery = value; }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries";
        }
    }
}
