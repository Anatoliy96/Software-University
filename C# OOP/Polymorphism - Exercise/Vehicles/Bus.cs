using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Drive
    {
        private bool isAirConditionerOn;

        public Bus(double fuelQuantity, double fuelConsumptionPerKilometer, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKilometer, tankCapacity)
        {
            isAirConditionerOn = false;
        }

        public void SetAirConditioner(bool isOn)
        {
            isAirConditionerOn = isOn;
        }

        public override string Driving(double distance)
        {
            double fuelConsumed = FuelConsumptionPerKilometer * distance;

            if (isAirConditionerOn)
            {
                fuelConsumed += 1.4 * distance;
            }

            if (fuelConsumed <= FuelQuantity)
            {
                FuelQuantity -= fuelConsumed;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }
    }
}
