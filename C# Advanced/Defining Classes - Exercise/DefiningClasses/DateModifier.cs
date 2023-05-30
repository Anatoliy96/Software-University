using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public int DiffrenceBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.ParseExact(firstDate, "yyyy MM dd", null);
            DateTime date2 = DateTime.ParseExact(secondDate, "yyyy MM dd", null);

            int difference = (int)(date2 - date1).TotalDays;
            return Math.Abs(difference);
        }
    }
}
