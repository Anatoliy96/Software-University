namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new();
            List<Product> products = new();

            try
            {
                string[] nameMoney = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var personNameMoney in nameMoney)
                {
                    string[] people = personNameMoney.Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Person person = new Person(people[0], decimal.Parse(people[1]));

                    persons.Add(person);
                }


                string[] productCostPairs = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                foreach (var productCostPair in productCostPairs)
                {
                    string[] productCost = productCostPair
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    Product product = new(productCost[0], decimal.Parse(productCost[1]));

                    products.Add(product);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personProduct = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personProduct[0];
                string productName = personProduct[1];

                Person person = persons.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person is not null && product is not null)
                {
                    Console.WriteLine(person.Add(product));
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons));
        }
    }
}
