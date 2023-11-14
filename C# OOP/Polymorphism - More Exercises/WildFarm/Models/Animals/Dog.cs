﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private double dogWeightMultiplier = 0.40;

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightMultiplier => dogWeightMultiplier;

        protected override IReadOnlyCollection<Type> PreferredFoodTypes => new HashSet<Type>() { typeof(Meat) };

        public override string ProduceSound()
        => "Woof!";
    }
}
