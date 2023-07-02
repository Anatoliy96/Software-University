namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);

            Drive car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);

            Drive truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commands[0];
                string vehicleType = commands[1];
                double distanceOrLiters = double.Parse(commands[2]);

                if (commands[0] == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Driving(distanceOrLiters));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(truck.Driving(distanceOrLiters));
                    }
                }
                else if (commands[0] == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(distanceOrLiters);
                    }

                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(distanceOrLiters);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
