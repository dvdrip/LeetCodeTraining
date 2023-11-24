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
            string myOut = Console.ReadLine();

            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            

            while (myOut != "")
            {
                Solution solution = new Solution();
                ListNode mergedList = solution.MergeTwoLists(list1, list2);

                myOut = Console.ReadLine();
            }
        }
    }
}
