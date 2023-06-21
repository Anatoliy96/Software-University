using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HoursePower = horsePower;
            Fuel = fuel;
        }

        public double Fuel { get; set; }
        public int HoursePower { get; set; }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        => Fuel -= kilometers * FuelConsumption;
    }
}
