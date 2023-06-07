namespace GenericCountMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                box.Add(element);
            }

            string comparedElemenet = Console.ReadLine();

            Console.WriteLine(box.CountOfComparedElemenets(comparedElemenet));
        }
    }
}
