using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Drive
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKilometer) : base(fuelQuantity, fuelConsumptionPerKilometer)
        {
        }

        public override string Driving(double distance)
        {
            double fuelConsumed = (FuelConsumptionPerKilometer + 0.9) * distance;

            if (fuelConsumed <= FuelQuantity)
            {
                FuelQuantity -= fuelConsumed;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public override double Refuel(double liters)
        {
            return FuelQuantity += liters;
        }
    }
}
