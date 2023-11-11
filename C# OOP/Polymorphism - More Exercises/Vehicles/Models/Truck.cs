using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double baseFuelConsumptionPerKilometer = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            double fuel = (FuelConsumption + baseFuelConsumptionPerKilometer) * distance;

            if (fuel <= FuelQuantity)
            {
                FuelQuantity -= fuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            Math.Ceiling(FuelQuantity += liters * 0.95);
        }
    }
}
