using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) 
            : base(name)
        {
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"{typeof(Warrior).Name} - {Name} hit for {Power} damage";
        }
    }
}
