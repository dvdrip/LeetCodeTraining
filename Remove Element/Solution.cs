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

            foreach (int i in nums)
            {
                Console.Write(i);

                if (i != val)
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

            return myIntArray.Length;
        }
    }
}
