using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCaloriesPerGram = 2;
        private Dictionary<string, double> typeOfToppingCalories;

        private string toppingType;
        private double caloriesPerGram;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            typeOfToppingCalories = new Dictionary<string, double>()
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                { "sauce", 0.9 }
            };

            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get => toppingType;
            private set
            {
                if (!typeOfToppingCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                toppingType = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double typeOfToppingModifier = typeOfToppingCalories[toppingType];

                return typeOfToppingModifier * weight * baseCaloriesPerGram;
            }
        }

        public double Weight
        {
            get => weight; 
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{value} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
    }
}
