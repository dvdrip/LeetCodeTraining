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

            while (current != null)
            {
                // something
            }

            return dummy;
        }

        public void TestLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(5);
            list.AddLast(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(3);
            list.AddFirst(3);

            var nodeToRemove = list.Find(3);

            list.Remove(nodeToRemove);

            list.RemoveLast();

            LinkedListNode<int> node = list.Find(3);
            list.AddAfter(node, 0);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

    }
}
