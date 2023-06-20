using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            StackOfStrings stack = new StackOfStrings();

            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange(IEnumerable<string> collection)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            foreach (var item in collection)
            {
                stackOfStrings.Push(item);
            }

            return stackOfStrings;
        }
    }
}
