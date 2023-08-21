namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] pizaaInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] doughtInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] toppingInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = doughtInput[0];
                string flourType = doughtInput[1];
                string bakingTechnique = doughtInput[2];
                double calories = double.Parse(doughtInput[3]);

                string pizzaType = pizaaInput[0];
                string pizzaName = pizaaInput[1];

                Dough dough = new Dough(flourType, bakingTechnique, calories);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (toppingInput[0] != "END")
                {
                    string toppingType = toppingInput[0];
                    string toppingTypeModifier = toppingInput[1];
                    double toppingCalories = double.Parse(toppingInput[2]);

                    Topping topping = new Topping(toppingTypeModifier, toppingCalories);

                    pizza.Add(topping);

                    toppingInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
