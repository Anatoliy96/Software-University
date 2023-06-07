using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> elemenets;

        public Box()
        {
            this.elemenets = new List<T>();
        }
        public void Add(T item)
        {
            elemenets.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in elemenets)
            {
                sb.AppendLine($"{typeof(T).FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
        public int CountOfComparedElemenets(T element)
        {
            int count = 0;

            foreach (T item in elemenets)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
