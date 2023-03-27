using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string car = input[0];
                int mileAge = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new Car());

                    cars[car].MileAge = mileAge;
                    cars[car].Fuel = fuel;

                }
                //cars[car].Add(mileAge, fuel);
            }

            string[] command = Console.ReadLine().Split(" : ");

            while (command[0] != "Stop")
            {
                if (command[0] == "Drive")
                {
                    string car = command[1];
                    int distance = int.Parse(command[2]);
                    int fuel = int.Parse(command[3]);

                    if (cars.ContainsKey(car))
                    {
                        if (cars[car].Fuel >= fuel)
                        {
                            cars[car].MileAge += distance;
                            cars[car].Fuel -= fuel;

                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        if (cars[car].MileAge >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);

                        }
                    }
                }
                else if (command[0] == "Refuel")
                {
                    string car = command[1];
                    int fuel = int.Parse (command[2]);

                    if (cars.ContainsKey(car))
                    {
                        int tankCapacity = 75;
                        int refuel = tankCapacity - cars[car].Fuel;

                        cars[car].Fuel += fuel;

                        if (cars[car].Fuel > tankCapacity)
                        {
                            Console.WriteLine($"{car} refueled with {refuel} liters");
                            cars[car].Fuel = tankCapacity;
                        }
                        else
                        {
                            Console.WriteLine($"{car} refueled with {fuel} liters");
                        }
                    }
                }
                else if (command[0] == "Revert")
                {
                    string car = command[1];
                    int kilometers = int.Parse(command[2]);

                    if (cars.ContainsKey(car))
                    {
                        cars[car].MileAge -= kilometers;
                        if (cars[car].MileAge < 10000)
                        {
                            cars[car].MileAge = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                    }
                }
                command = Console.ReadLine().Split(" : ");
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.MileAge} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }

        public class Car
        {
            public int MileAge { get; set; }
            public int Fuel { get; set; }
        }
    }
}
