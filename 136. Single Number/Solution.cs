using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _136._Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int distinctNum = nums.GroupBy(x => x).Where(y => y.Count() == 1).Select(g => g.Key).FirstOrDefault();
            return distinctNum;
        }
    }
}
