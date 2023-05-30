using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        //public Car()
        //{
        //    Make = "VW";
        //    Model = "Golf";
        //    Year = 2025;
        //    FuelQuantity = 200;
        //    FuelConsumption = 10;
        //}

        //public Car(string make, string model, int year) : this()
        //{
        //    this.Make = make;
        //    this.Model = model;
        //    this.Year = year;
        //}

        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption):this(make, model, year)
        //{
        //    this.FuelQuantity = fuelQuantity;
        //    this.FuelConsumption = fuelConsumption;
        //}

        //public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        //    : this(make, model, year, fuelQuantity, fuelConsumption)
        //{
        //    Engine = engine;
        //    Tires = tires;
        //}

        public Car(string make, string model, int year, int horsePower, double fuelQuantity,
          double fuelConsumption, int engineIndex, int tiresIndex, double totalPressure)
        {
            Make = make;
            Model = model;
            Year = year;
            HorsePower = horsePower;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            EngineIndex = engineIndex;
            TiresIndex = tiresIndex;
            TotalPressure = totalPressure;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public int HorsePower { get; set; }

        public int EngineIndex { get; set; }

        public int TiresIndex { get; set; }

        public double TotalPressure { get; set; }
        //public Engine Engine
        //{
        //    get { return engine; }
        //    set { engine = value; }
        //}

        //public Tire[] Tires
        //{
        //    get { return tires; }
        //    set { tires = value; }
        //}

        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (FuelConsumption / 100) * 20;

            return fuelQuantity;
        }
        public void Drive(double distance)
        {
            double fuelNeeded = distance * fuelConsumption;

            if (FuelQuantity - fuelNeeded >= 0)
            {
                FuelQuantity -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Make: {this.Make}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Year: {this.Year}");
            stringBuilder.AppendLine($"Fuel: {this.FuelQuantity:F2}");

            return stringBuilder.ToString();
        }
    }
}
