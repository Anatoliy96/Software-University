using System;
using System.Collections.Generic;

namespace _2._Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        {
            List<int> dummy = new List<int>(0);
            List<int> p = l1, q = l2, curr = dummy;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p. : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummy.next;
        }
}
