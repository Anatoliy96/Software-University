using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return true; // Null values are considered valid; use [Required] attribute for non-null validation
            }

            if (obj is not IComparable comparable)
            {
                throw new ArgumentException("The property type must implement IComparable interface.");
            }

            return comparable.CompareTo(minValue) >= 0 && comparable.CompareTo(maxValue) <= 0;
        }
    }
}
