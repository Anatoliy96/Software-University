namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            //Console.WriteLine(firstCar.WhoAmI());
            //Console.WriteLine();
            //Console.WriteLine(secondCar.WhoAmI());
            //Console.WriteLine();
            //Console.WriteLine(thirdCar.WhoAmI());
            //Console.WriteLine();

            var tires = new Tire[4]
            {
                new Tire(2000, 1.25),
                new Tire(2000, 1.25),
                new Tire(2000, 1.25),
                new Tire(2000, 1.25),
            };
            
            var engine = new Engine(560, 6300);

            var car = new Car("Audi", "A3", 2001, 45, 7, engine, tires);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
