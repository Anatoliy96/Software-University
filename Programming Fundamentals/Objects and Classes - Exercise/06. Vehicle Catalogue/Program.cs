using System;
using System.Collections.Generic;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Venihle> venihles = new List<Venihle>();

            double countOfCars = 0;
            double countOfTrucks = 0;
            int carsHoursePower = 0;
            int trucksHoursePower = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] currentVehicle = command.Split(' ');

                Venihle venihle = new Venihle(currentVehicle[0], currentVehicle[1], currentVehicle[2], int.Parse(currentVehicle[3]));

                venihles.Add(venihle);

                if (currentVehicle[0] == "car")
                {
                    carsHoursePower += venihle.HoursePower;
                    countOfCars++;
                }
                else
                {
                    trucksHoursePower += venihle.HoursePower;
                    countOfTrucks++;
                }
            }

            command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                foreach (var v in venihles)
                {
                    if (command == v.Model)
                    {
                        Console.WriteLine($"Type: {v.Type[0].ToString().ToUpper()}{(v.Type.Substring(1))}");
                        Console.WriteLine($"Model: {v.Model}");
                        Console.WriteLine($"Color: {v.Color}");
                        Console.WriteLine($"Horsepower: {v.HoursePower}");
                    }
                    else
                    {
                        continue;
                    }
                }

                command = Console.ReadLine();
            }
            double averageHoursePowerOfCars = carsHoursePower / countOfCars;
            double averageHoursePowerOfTrucks = trucksHoursePower / countOfTrucks;

            Console.WriteLine($"Cars have average horsepower of: {averageHoursePowerOfCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHoursePowerOfTrucks:f2}.");
        }
    }

    public class Venihle
    {
        public Venihle(string type, string model, string color, int hoursePower)
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
