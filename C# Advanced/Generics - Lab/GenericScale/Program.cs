namespace GenericScale
{
    public class StartUp 
    {
        public static void Main()
        {
            EqualityScale<int> equal = new EqualityScale<int>(6, 5);
            Console.WriteLine(equal.AreEqual());
        }
    }
}
