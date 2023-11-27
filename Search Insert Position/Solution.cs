using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int myIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    myIndex = i;
                }
            }

            return myIndex;
        }
    }
}
