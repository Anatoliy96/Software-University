using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private double henWeightMultiplier = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightMultiplier => henWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes => 
            new HashSet<Type>() { typeof(Meat) , typeof(Fruit), typeof(Seeds), typeof(Vegetable)};

        public override string ProduceSound()
        => "Cluck";
    }
}
