using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            List<int> list = new List<int>();



            foreach (int i in nums)
            {
                if (i != val)
                {
                    list.Add(i);
                }
            }

            int[] myIntArray = list.ToArray();

            for (int i = 0; i < myIntArray.Length; int++)
            {
                Console.WriteLine(myIntArray[i]);
            }

            return myIntArray.Length;
            
        }
    }
}
