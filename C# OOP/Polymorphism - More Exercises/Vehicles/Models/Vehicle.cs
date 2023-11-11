using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;

            if (TankCapacity < FuelQuantity)
            {
                TankCapacity = 0;
            }
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public int TankCapacity { get; set; }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
