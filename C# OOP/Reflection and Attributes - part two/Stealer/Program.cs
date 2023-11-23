namespace Stealer
{
    public class StartUp
    {
        public static void Main()
        {
            Spy spy = new Spy();

            string result = spy.StealFieldInfo("Stealer.Hacker", new string[] { "username", "password" });

            Console.WriteLine(result);
        }
    }
}
