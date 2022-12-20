using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
     class Program
    {
        static void Main(string[] args)
        {
            string command;

            Catalog catalogs = new Catalog();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split("/");

                string type = tokens[0];

                if (type == "Car")
                {
                    Car car = new Car();

                    car.Brand = tokens[1];
                    car.Model = tokens[2];
                    car.HoursePower = int.Parse(tokens[3]);

                    catalogs.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = tokens[1];
                    truck.Model = tokens[2];
                    truck.Weight = int.Parse(tokens[3]);

                    catalogs.Trucks.Add(truck);
                }
            }

            if (catalogs.Cars.Count > 0)
            {
                List<Car> sortedCars = new List<Car>();
                sortedCars = catalogs.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }
            if (catalogs.Trucks.Count > 0)
            {
                List<Truck> sortedTruck = new List<Truck>();
                sortedTruck = catalogs.Trucks.OrderBy(t => t.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (var truck in sortedTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HoursePower { get; set; }
        }

        public class Catalog
        {
            public Catalog()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();
            }
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
        }
    }
}
