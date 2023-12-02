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

            List<int> uniqueList = numberList.Distinct().ToList();

            int[] uniqueArray = uniqueList.ToArray();

            Console.WriteLine("Array: ");

            foreach (int i in uniqueArray)
            {
                Console.WriteLine(i);
            }

            return uniqueArray.Length;
        }
    }
}
