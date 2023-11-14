using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using WildFarm.Core.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Foods;
using WildFarm.Models.Interfaces;

namespace WildFarm
{
    public class StartUp
    {
        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;

        public StartUp(
        IAnimalFactory animalFactory,
        IFoodFactory foodFactory)
        {
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

           
        }

        public static void Main()
        {

            List<IAnimal> animals = new List<IAnimal>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                IAnimal animal = null;

                try
                {
                    animal = CreateAnimal(command);

                    IFood food = CreateFood();

                    Console.WriteLine(animal.ProduceSound());

                    animal.Eat(food);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }


        }

        private IAnimal CreateAnimal(string command)
        {
            string[] animalArgs = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IAnimal animal = animalFactory.CreateAnimal(animalArgs);

            return animal;
        }

        private IFood CreateFood()
        {
            string[] foodTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodType = foodTokens[0];
            int foodQuantity = int.Parse(foodTokens[1]);

            IFood food = foodFactory.CreateFood(foodType, foodQuantity);

            return food;
        }
    }
}
