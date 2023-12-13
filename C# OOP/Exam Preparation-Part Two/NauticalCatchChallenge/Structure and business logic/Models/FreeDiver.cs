using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class FreeDiver : Diver
    {
        private const int oxygenLevel = 120;

        public FreeDiver(string name) 
            : base(name, oxygenLevel)
        {
        }

        public override void Miss(int TimeToCatch)
        {
            int usedOxygenlvl = (int)Math.Round(TimeToCatch * 0.6);
            base.OxygenLevel -= usedOxygenlvl;
        }

        public override void RenewOxy()
        {
            base.OxygenLevel = oxygenLevel;
        }
    }
}
