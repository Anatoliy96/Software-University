using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Tyres
    {
        public Tyres(double tire1Pressure, int tire1Age)
        {
            Pressure = tire1Pressure;
            Age = tire1Age;
        }

        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
