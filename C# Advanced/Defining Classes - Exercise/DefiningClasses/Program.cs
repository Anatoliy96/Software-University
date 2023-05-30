namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            int diffrence = dateModifier.DiffrenceBetweenTwoDates(firstDate, secondDate);

            Console.WriteLine(diffrence);
        }
    }
}
