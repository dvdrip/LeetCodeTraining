using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };

            Solution solution = new Solution();
            int k = solution.RemoveDuplicates(nums);
            Console.WriteLine($"Count left: {k}");

            Console.ReadLine();
        }
    }
}
