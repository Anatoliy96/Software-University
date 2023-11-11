using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name) 
            : base(name)
        {
            Power = 80;
        }

        public override string CastAbility()
        {
            return $"{typeof(Druid).Name} - {Name} healed for {Power}";
        }
    }
}
