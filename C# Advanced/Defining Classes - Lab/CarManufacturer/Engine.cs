using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        private int hoursePower;
        private double cubicCapacity;

        public Engine(int hoursePower, double cubicCapacity)
        {
            HoursePower = hoursePower;
            CubicCapacity = cubicCapacity;
        }

        public int HoursePower
        {
            get { return hoursePower; }
            set { hoursePower = value; }
        }

        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }

    }
}
