using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Solution
    {
        public void ReverseString(char[] s)
        {
            string reversedString = "";

            for (int i = s.Length - 1; i >= 0; i--) {

                reversedString += s[i];
            }

            char[] reversedChar = reversedString.ToCharArray();

            Console.WriteLine(reversedChar);
        }
    }
}
