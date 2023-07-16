namespace Stealer
{
    public class StartUp
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string name = Console.ReadLine();

            spy.AnalyzeAccessModifiers(name);
        }
    }
}
