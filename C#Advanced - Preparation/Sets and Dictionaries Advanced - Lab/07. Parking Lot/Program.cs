using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> cars = new HashSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    string carPlateNumber = input[1];
                    cars.Add(carPlateNumber);
                }
                else if (input[0] == "OUT")
                {
                    string carPlateNumber = input[1];
                    cars.Remove(carPlateNumber);
                }

                input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            }
            if (cars.Count > 0)
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
