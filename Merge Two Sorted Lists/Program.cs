using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode();
            list1.val = 1;
            list1.val = 2;
            list1.val = 4;

            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            Solution solution = new Solution();
            solution.MergeTwoLists(list1, list2);

            Console.ReadLine();
        }
    }
}
