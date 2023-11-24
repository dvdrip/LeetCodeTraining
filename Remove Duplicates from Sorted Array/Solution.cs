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
            List<int> numberList = new List<int>(nums);

            // Remove duplicates using Distinct
            List<int> uniqueList = numberList.Distinct().ToList();

            // Convert the List<int> back to an array
            int[] uniqueArray = uniqueList.ToArray();

            return uniqueArray.Length;
        }
    }
}
