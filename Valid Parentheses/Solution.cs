using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class Solution
    {
        public bool IsValid(string s)
        {
            if (s == null) return false;

            char startChar = s[0];
            char endChar = s[s.Length - 1];

            if (startChar == '(' && endChar == ')')
            {
                return true;
            }
            else if (startChar == '{' && endChar == '}')
            {
                return true;
            }
            else if (startChar == '[' && endChar == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static char GetOppositeChar(char inputChar)
        {
            switch (inputChar)
            {
                case '(':
                    return ')';
                case ')':
                    return '(';
                case '[':
                    return ']';
                case ']':
                    return '[';
                case '{':
                    return '}';
                case '}':
                    return '{';
                // Add more cases as needed
                default:
                    return inputChar; // If the input is not a recognized character, return the same character
            }
        }
    }
}
