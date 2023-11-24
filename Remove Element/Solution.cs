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

            Console.WriteLine($"The array with val: {val}");

            Console.Write("{");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(i);
                if (nums[i] != val)
                {
                    list.Add(i);
                }
            }

            Console.Write("}");

            Console.WriteLine("");

            Console.WriteLine("Converting list to array...");

            int[] myIntArray = list.ToArray();

            Console.Write("{");

            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.Write(myIntArray[i]);
            }

            Console.Write("}");

            Console.WriteLine();

            int[] myReturnArray = new int[nums.Length];

            for (int i = 0; i < myIntArray.Length; i++)
            {
                myReturnArray[i] = list[i];
            }

            return myIntArray.Length;
        }

        public int RemoveElement2(int[] nums, int val)
        {
            int k = 0;
            int[] expectedNums = nums;

            Console.WriteLine($"The array with val: {val}");

            Console.Write("{");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);

                if (nums[i] != val)
                {
                    expectedNums[i] = nums[i];
                    k++;
                }
                else
                {
                    expectedNums[i] = 9;
                }
            }

            Console.Write("}");

            Console.WriteLine();

            for (int i = 0; i < expectedNums.Length; i++)
            {
                Console.Write(expectedNums[i]);
                
            }
            Console.WriteLine();

            return k;
        }
    }
}
