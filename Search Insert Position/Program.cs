using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;

            Solution solution = new Solution();

            int myIndex = solution.SearchInsert(nums, target);

            Console.WriteLine(myIndex);

            Console.ReadLine();
        }
    }
}
