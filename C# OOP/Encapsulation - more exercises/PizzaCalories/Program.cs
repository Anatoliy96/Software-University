namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            string[] doughtInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (doughtInput[0] != "END") 
            {
                try
                {
                    string[] toppingInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string type = doughtInput[0];
                    string flourType = doughtInput[1];
                    string bakingTechnique = doughtInput[2];
                    double calories = double.Parse(doughtInput[3]);

                    string toppingType = toppingInput[0];
                    string toppingTypeModifier = toppingInput[1];
                    double toppingCalories = double.Parse(toppingInput[2]);

                    Dough dough = new Dough(flourType, bakingTechnique, calories);
                    Topping topping = new Topping(toppingTypeModifier, toppingCalories);

                    Console.WriteLine($"{dough.CaloriesPerGram:f2}");
                    Console.WriteLine($"{topping.CaloriesPerGram:f2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                doughtInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
