﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double baseFuelConsumptionPerKilometer = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
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
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            FuelQuantity += liters * 0.95;

            if (TankCapacity < FuelQuantity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                FuelQuantity -= liters * 0.95;
            }
        }
    }
}
