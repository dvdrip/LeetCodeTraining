using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _58.Length_of_Last_Word
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            string[] words = s.Split(' ');

            return words[words.Length - 1].Trim().Length;
        }

        static string RemoveExtraSpaces(string input)
        {
            // Flag to track if the current character is a space
            bool isPreviousCharSpace = false;

            // Create a new string with only single spaces between words
            string cleanedString = "";
            foreach (char c in input)
            {
                if (Char.IsWhiteSpace(c))
                {
                    // If the current character is a space, set the flag
                    isPreviousCharSpace = true;
                }
                else
                {
                    // If the current character is not a space, append it to the result string
                    if (isPreviousCharSpace)
                    {
                        cleanedString += " ";
                        isPreviousCharSpace = false;
                    }
                    cleanedString += c;
                }
            }

            return cleanedString;
        }
    }
}
