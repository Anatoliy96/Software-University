﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {

        private List<T> items { get; set; }

        public Box()
        {
            items = new List<T>();
        }

        public int Count
        {
            get { return items.Count; }
            
        }
        
        public void Add(T element)
        {
            items.Add(element);
        }

        public T Remove()
        {
            T lastElement = items[items.Count - 1];

            items.Remove(lastElement);

            return lastElement;
        }
    }
}
