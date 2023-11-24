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
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            Solution solution = new Solution();
            var x = solution.RemoveElement(nums, val);
            Console.WriteLine("My out " + x);
            Console.ReadLine();
        }
    }
}
