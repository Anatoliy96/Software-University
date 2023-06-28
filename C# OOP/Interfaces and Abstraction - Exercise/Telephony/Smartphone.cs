using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (!IsValid(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (!IsValidURL(url))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
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

        private bool IsValidURL(string url)
        {
           return url.All(c => !char.IsDigit(c));
        }
    }
}
