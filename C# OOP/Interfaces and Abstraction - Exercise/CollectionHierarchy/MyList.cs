using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class MyList : IMyList
    {
        private const int AddIndex = 0;
        private const int RemoveIndex = 0;

        private readonly List<string> myList;

        public MyList()
        {
            myList = new List<string>();
        }

        public int Used => myList.Count;

        public int Add(string item)
        {
            myList.Insert(AddIndex, item);

            return AddIndex;
        }

        public string Remove()
        {
            string item = myList[RemoveIndex];

            myList.RemoveAt(RemoveIndex);

            return item;
        }
    }
}
