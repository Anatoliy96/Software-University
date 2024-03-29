﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        protected abstract double WeightMultiplier { get; }

        protected abstract IReadOnlyCollection<Type> PreferredFoodTypes { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!PreferredFoodTypes.Any(pf => food.GetType().Name == pf.Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            Weight += food.Quantity * WeightMultiplier;

            FoodEaten += food.Quantity;
        }

        public IAnimal CreateAnimal(string[] animalArgs)
        {
            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            switch (type)
            {
                case "Owl":
                    return new Owl(name, weight, double.Parse(animalArgs[3]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(animalArgs[3]));
                case "Mouse":
                    return new Mouse(name, weight, animalArgs[3]);
                case "Dog":
                    return new Dog(name, weight, animalArgs[3]);
                case "Cat":
                    return new Cat(name, weight, animalArgs[3], animalArgs[4]);
                case "Tiger":
                    return new Tiger(name, weight, animalArgs[3], animalArgs[4]);
                default:
                    throw new ArgumentException("Invalid animal type!");
            }
        }

        public override string ToString()
            => $"{GetType().Name} [{Name}, ";

    }
}
