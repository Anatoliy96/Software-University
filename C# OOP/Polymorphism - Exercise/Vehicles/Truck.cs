using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Drive
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKilometer, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKilometer, tankCapacity)
        {
        }

        public override string Driving(double distance)
        {
            double fuelConsumed = (FuelConsumptionPerKilometer + 1.6) * distance;

            if (fuelConsumed <= FuelQuantity)
            {
                FuelQuantity -= fuelConsumed;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters;

            if (FuelQuantity > TankCapacity)
            {
                FuelQuantity -= liters;
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            base.Refuel(liters * 0.95);
        }
    }
}
