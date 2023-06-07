namespace GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                box.Add(element);
            }

            double comparedElemenet = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CountOfComparedElemenets(comparedElemenet));
        }
    }
}
