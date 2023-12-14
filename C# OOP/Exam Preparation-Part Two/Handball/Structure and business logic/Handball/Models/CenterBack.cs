using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Models
{
    public class CenterBack : Player
    {
        private const double rating = 4;

        public CenterBack(string name) 
            : base(name, rating)
        {
        }

        public override void DecreaseRating()
        {
            base.Rating -= 1;

            if (Rating < 1)
            {
                base.Rating = 1;
            }
        }

        public override void IncreaseRating()
        {
            base.Rating += 1;

            if (Rating > 10)
            {
                base.Rating = 10;
            }
        }
    }
}
