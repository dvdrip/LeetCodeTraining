using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;

            if (nums != null)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    LinkedList<int> list = new LinkedList<int>();

                    Console.WriteLine(nums[i]);
                }
            }

            return k;
        }
    }
}
