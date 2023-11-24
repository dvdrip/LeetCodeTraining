using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            Solution solution = new Solution();
            var x = solution.RemoveElement(nums, val);
            Console.WriteLine("Elements left " + x);
            Console.ReadLine();
        }
    }
}
