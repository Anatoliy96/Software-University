﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) 
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavoriteFood} DJAAF";
        }
    }
}
