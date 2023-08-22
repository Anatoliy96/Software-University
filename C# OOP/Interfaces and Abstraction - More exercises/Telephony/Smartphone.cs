using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            bool IsValid = ContainsDigitsInUrl(url);

            if (IsValid)
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Calling(string phoneNumber)
        {
            bool isValid = phoneNumber.All(char.IsDigit);

            if (!isValid)
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }

        static bool ContainsDigitsInUrl(string url)
        {
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
