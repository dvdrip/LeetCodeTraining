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

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    list.Add(i);
                }
            }

            int[] myIntArray = list.ToArray();

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

        public int GetAnswer(int[] nums, int val)
        {
            int index = 0; // Use this index to overwrite the array in-place

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i]; // Overwrite the array in-place
                    index++;
                }
            }

            // index now represents the length of the modified array
            return index;
        }
    }
}
