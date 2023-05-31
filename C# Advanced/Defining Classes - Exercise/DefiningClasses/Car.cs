using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(
        string model,
        int speed,
        int power,
        int weight,
        string type,
        double tyre1pressure,
        int tyre1age,
        double tyre2pressure,
        int tyre2age,
        double tyre3pressure,
        int tyre3age,
        double tyre4pressure,
        int tyre4age)
        {

            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tyres[4];
            Tires[0] = new(tyre1pressure, tyre1age);
            Tires[1] = new(tyre2pressure, tyre2age);
            Tires[2] = new(tyre3pressure, tyre3age);
            Tires[3] = new(tyre4pressure, tyre4age);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyres[] Tires { get; set; }

    }
}
