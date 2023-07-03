using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Drive
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKilometer;
        private double tankCapacity;

        protected Drive(double fuelQuantity, double fuelConsumptionPerKilometer, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TankCapacity = tankCapacity;

            if (fuelQuantity > TankCapacity )
            {
                fuelQuantity = 0;
            }
        }

        public double FuelQuantity 
        { 
            get => fuelQuantity; 
            protected set { fuelQuantity = value; }
        }
        public double FuelConsumptionPerKilometer 
        {
            get => fuelConsumptionPerKilometer; 
            protected set => fuelConsumptionPerKilometer = value; 
        }
        public double TankCapacity 
        { 
            get => tankCapacity; 
            protected set => tankCapacity = value; 
        }

        public abstract string Driving(double distance);

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            FuelQuantity += liters;

            if (FuelQuantity > TankCapacity)
            {
                FuelQuantity -= liters;
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
        }
       
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
