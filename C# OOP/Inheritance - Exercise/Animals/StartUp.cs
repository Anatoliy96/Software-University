using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = Console.ReadLine();
            string[] objectInput = Console.ReadLine().Split(' ');

            while (animalType != "Beast!")
            {
                string name = objectInput[0];
                int age = int.Parse(objectInput[1]);
                string gender = objectInput[2];

                if (animalType == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    PrintAnimal(animalType, dog);
                }
                else if (animalType == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    PrintAnimal(animalType, cat);
                }
                else if (animalType == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    PrintAnimal(animalType, frog);
                }
                else if (animalType == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age, gender);
                    PrintAnimal(animalType, kitten);
                }
                else if (animalType == "TomCat")
                {
                    Tomcat tomCat = new Tomcat(name, age, gender);
                    PrintAnimal(animalType, tomCat);
                }

                animalType = Console.ReadLine();
                objectInput = Console.ReadLine().Split(' ');
            }
        }

        private static void PrintAnimal<T>(string animalType, T animal) where T : Animal
        {
            Console.WriteLine(animalType);
            Console.WriteLine(animal.ToString());
        }
    }
}
