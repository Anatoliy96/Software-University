using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Drive
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKilometer, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKilometer, tankCapacity)
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

        //public override void Refuel(double liters)
        //{
        //    if (liters <= 0)
        //    {
        //        Console.WriteLine($"Fuel must be a positive number");
        //    }

        //    FuelQuantity += liters;

        //    if (FuelQuantity > TankCapacity) 
        //    {
        //        FuelQuantity -= liters;
        //        Console.WriteLine($"Cannot fit {FuelQuantity} fuel in the tank");
        //    }

        //    FuelQuantity += liters;
        //}
    }
}
