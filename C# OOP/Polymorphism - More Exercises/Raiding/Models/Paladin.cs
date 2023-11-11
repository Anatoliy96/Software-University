using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) 
            : base(name)
        {
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"{typeof(Paladin).Name} - {Name} healed for {Power}";
        }
    }
}
