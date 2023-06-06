using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T name;

        public Box(T name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{typeof(T).FullName}: {name}");

            return sb.ToString().TrimEnd();
        }
    }
}
