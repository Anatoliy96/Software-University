using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name)
            : base(name)
        {
            Power = 80;
        }

        public override string CastAbility()
        {
            return $"{typeof(Rogue).Name} - {Name} hit for {Power} damage";
        }
    }
}
