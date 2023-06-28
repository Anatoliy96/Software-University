using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!IsValid(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }

        private bool IsValid(string number)
        {
            int result;

            if (!int.TryParse(number, out result))
            {
                return false;
            }
            return true;
        }
    }
}
