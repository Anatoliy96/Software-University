using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator()
        {
            this.list = new List<T>();
            this.index = 0;
        }

        public void Create(T element)
        {
            list.Add(element);
        }
        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            return index < list.Count - 1;
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
            
        }
    }
}
