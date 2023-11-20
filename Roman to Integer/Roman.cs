using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Roman_to_Integer
{
    public class Roman
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool isLastSymbol = i == s.Length - 1;
                bool shouldSubtract = !isLastSymbol && romanValues[s[i]] < romanValues[s[i + 1]];

                if (shouldSubtract)
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }

            return result;
        }

        //public Dictionary<char, int> romanNumerals()
        //{
        //    Dictionary<char, int> myDict = new Dictionary<char, int>
        //    {
        //        {'I', 1},
        //        {'V', 5},
        //        {'X', 10},
        //        {'L', 50},
        //        {'C', 100},
        //        {'D', 500},
        //        {'M', 1000}
        //    };

        //    return myDict;
        //}
    }
}
