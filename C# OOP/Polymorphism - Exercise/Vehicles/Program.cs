namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);
            double carTankCapacity = double.Parse(carInput[3]);

            Drive car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            string[] truckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);
            double truckTankCapacity = double.Parse(truckInput[3]);

            Drive truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            string[] busInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double busFuelQuantity = double.Parse(busInput[1]);
            double busFuelConsumption = double.Parse(busInput[2]);
            double busTankCapacity = double.Parse(busInput[3]);

            Drive bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = commands[0];
                string vehicleType = commands[1];
                double distanceOrLiters = double.Parse(commands[2]);

                try
                {
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
                        else if (vehicleType == "Bus")
                        {
                            if (vehicleType == "DriveEmpty")
                            {
                                bus.;
                            }
                            else
                            {
                                bus.SetAirConditioner(true);
                            }
                            Console.WriteLine(bus.Driving(distanceOrLiters));
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
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(distanceOrLiters);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}

