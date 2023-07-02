using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Drive
    {
        private string type;
        private double fuelQuantity;
        private double fuelConsumptionPerKilometer;

        protected Drive(double fuelQuantity, double fuelConsumptionPerKilometer)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public double FuelQuantity 
        { 
            get => fuelQuantity; 
            protected set => fuelQuantity = value; 
        }
        public double FuelConsumptionPerKilometer 
        {
            get => fuelConsumptionPerKilometer; 
            protected set => fuelConsumptionPerKilometer = value; 
        }

        public abstract string Driving(double distance);
        public abstract double Refuel(double liters);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
