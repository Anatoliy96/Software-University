using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] command = Console.ReadLine().Split(" ");

            int carsHoursePower = 0;
            int trucksHoursePower = 0;

            while (command[0] != "End")
            {
                string type = command[0];
                string model = command[1];
                string color = command[2];
                int hoursePower = int.Parse(command[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hoursePower);

                vehicles.Add(vehicle);

                if (vehicle.Type == "car")
                {
                    carsHoursePower += vehicle.HoursePower;
                    
                }
                else if (vehicle.Type == "truck")
                {
                    trucksHoursePower += vehicle.HoursePower;
                }

                command = Console.ReadLine().Split(" ");
            }

            command = Console.ReadLine().Split(" ");

            while (command[0] != "Close" || command[1] != "the" || command[2] != "Catalogue")
            {
                string model = command[0];

                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == model)
                    {
                        string capitalized = char.ToUpper(vehicle.Type[0]) + vehicle.Type.Substring(1);
                        Console.WriteLine($"Type: {capitalized}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HoursePower}");
                        break;
                    }
                }
                command = Console.ReadLine().Split(" ");
            }

            List<Vehicle> cars = vehicles.Where(v => v.Type == "car").ToList();
            List<Vehicle> trucks = vehicles.Where(v => v.Type == "truck").ToList();

            double carsAverageHoursePower = (double)carsHoursePower / cars.Count;
            double trucksAverageHoursePower = (double)trucksHoursePower / trucks.Count;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHoursePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHoursePower:f2}.");
        }

        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int hoursePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HoursePower = hoursePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HoursePower { get; set; }
        }
    }
}
