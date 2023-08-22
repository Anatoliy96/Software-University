using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string phoneNumber)
        {
            bool isValid = phoneNumber.All(char.IsDigit);

            if (!isValid)
            {
                return "Invalid number!";
            }

            return $"Dialing... {phoneNumber}";
        }
    }
}
