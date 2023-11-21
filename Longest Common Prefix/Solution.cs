﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            int shortestLength = strs.Min(s => s.Length);

            for (int i = 0; i < shortestLength; i++)
            {
                char currentChar = strs[0][i];

                if (strs.Any(s => s[i] != currentChar))
                {
                    // Stop when a non-matching character is found
                    return strs[0].Substring(0, i);
                }
            }

            // All characters matched, return the entire string
            return strs[0].Substring(0, shortestLength);
        }

    }
}
