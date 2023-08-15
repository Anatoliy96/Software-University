using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class Goalkeeper : Player
    {
        private const double Rating = 2.5;

        public Goalkeeper(string name) : base(name, Rating)
        {
           
        }

        public override void DecreaseRating()
        {
            base.Rating -= 1.25;

            if (base.Rating < 1)
            {
                base.Rating = 1;
            }
        }

        public override void IncreaseRating()
        {
            base.Rating += 0.75;

            if (base.Rating > 10)
            {
                base.Rating = 10;
            }
        }
    }
}
