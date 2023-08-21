using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.name = name;
            toppings = new List<Topping>();
            Dough = dough;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }
        public Dough Dough 
        { 
            get => dough; 
            set => dough = value; 
        }
        public List<Topping> Toppings 
        { 
            get => toppings;
        }

        public double TotalCalories 
        {
            get
            {
                return Dough.CaloriesPerGram + toppings.Sum(t => t.CaloriesPerGram);
            }
        }

        public void Add(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:f2} Calories.";
        }

    }
}
