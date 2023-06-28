namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ICallable phone;

            foreach (string number in numbers)
            {
                if (number.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }
                try
                {
                    Console.WriteLine(phone.Call(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable smartPhone = new Smartphone();

            foreach (string url in urls)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(url));
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
