using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private const int addIndex = 0;
        private readonly List<string> myList;

        public AddRemoveCollection()
        {
            myList = new List<string>();
        }

        public int Add(string item)
        {
            myList.Insert(addIndex, item);

            return addIndex;
        }

        public string Remove()
        {
            string item = string.Empty;

            if (myList.Count > 0)
            {
                item = myList[myList.Count - 1];
                myList.RemoveAt(myList.Count - 1);
            }

            return item;
        }
    }
}
