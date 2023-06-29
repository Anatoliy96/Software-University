using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer : IPersonality
    {
        public int Food { get; }

        void BuyFood();
    }
}
