using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Drive
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKilometer) : base(fuelQuantity, fuelConsumptionPerKilometer)
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

        public override double Refuel(double liters)
        {
            double refueledAmount = liters * (1 - 0.05);
            FuelQuantity += refueledAmount;

            return FuelQuantity;
        }
    }
}
