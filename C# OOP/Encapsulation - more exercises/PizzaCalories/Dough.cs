using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private const double baseCaloriesPerGram = 2;
        private Dictionary<string, double> flourTypeCalories;
        private Dictionary<string, double> bakingTechniqueCalories;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.flourTypeCalories = new Dictionary<string, double>()
            {
                { "white", 1.5 },
                { "wholegrain", 1.0 }
            };

            this.bakingTechniqueCalories = new Dictionary<string, double>()
            {
                { "crispy", 0.9 },
                { "chewy", 1.1 },
                { "homemade" , 1}
            };

            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double CaloriesPerGram
        {
            get
            {
                double bakingTypeModifier = bakingTechniqueCalories[BakingTechnique];
                double flourTypeModifier = flourTypeCalories[FlourType];

                return baseCaloriesPerGram * weight * flourTypeModifier * bakingTypeModifier; 
            }
        }
        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!flourTypeCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value.ToLower();
            }
        }
        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }
    }
}
