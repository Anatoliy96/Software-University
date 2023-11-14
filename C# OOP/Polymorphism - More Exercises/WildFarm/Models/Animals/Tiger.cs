using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private double tigerWeightMultiplier = 1.00;

        public Tiger(string name, double weight, string breed) 
            : base(name, weight, breed)
        {
        }

        protected override double WeightMultiplier => tigerWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes => new HashSet<Type>() { typeof(Meat)} ;

        public override string ProduceSound()
        => "ROAR!!!";
    }
}
