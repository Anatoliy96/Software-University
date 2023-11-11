using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private double baseConsumptionWithPeople = 1.4;
        private bool isAirConditionerOn;

        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            isAirConditionerOn = false;
        }

        public void SetAirConditioner(bool isOn)
        {
            isAirConditionerOn = isOn;
        }

        public override void Drive(double distance)
        {
            double fuel = FuelConsumption * distance;

            if (isAirConditionerOn)
            {
                fuel += baseConsumptionWithPeople * distance;
            }

            if (fuel <= FuelQuantity)
            {
                FuelQuantity -= fuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            FuelQuantity += liters;

            if (TankCapacity < FuelQuantity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                FuelQuantity -= liters;
            }
        }
    }
}
