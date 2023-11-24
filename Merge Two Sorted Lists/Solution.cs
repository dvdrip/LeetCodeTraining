using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    internal class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            // If one of the lists is not empty, append the remaining nodes
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummy.next;
        }
    }

}
