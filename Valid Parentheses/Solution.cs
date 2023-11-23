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
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false; // No corresponding open bracket
                    }

                    char openBracket = stack.Pop();

                    if ((c == ')' && openBracket != '(') ||
                        (c == '}' && openBracket != '{') ||
                        (c == ']' && openBracket != '['))
                    {
                        return false; // Mismatched brackets
                    }
                }
            }

            return stack.Count == 0; // Check if all open brackets are closed
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
