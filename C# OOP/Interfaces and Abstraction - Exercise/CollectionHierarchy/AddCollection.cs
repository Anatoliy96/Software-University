using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddCollection : IAddCollection
    {
        private List<string> myList;

        public AddCollection()
        {
            myList = new List<string>();
        }
        public int Add(string item)
        {
            myList.Add(item);

            return myList.Count - 1;
        }
    }
}
