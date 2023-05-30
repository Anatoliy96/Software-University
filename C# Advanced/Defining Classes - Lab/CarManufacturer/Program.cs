namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new Tire[4]
           {
               new Tire(2020, 1.8),
               new Tire(2020, 1.8),
               new Tire(2020, 1.8),
               new Tire(2020, 1.8)
            };

            var engine = new Engine(560, 6300);

            var car = new Car("Lamborgini", "Urus", 2022, 200, 20, engine, tires);
            Console.WriteLine(car.Engine.HoursePower + " " + car.Engine.CubicCapacity);
            Console.WriteLine(car.Tires[0].Year + " " + car.Tires[0].Pressure);
        }
    }
}
