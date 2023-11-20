﻿using System;
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
            int myVal = 0;

            char[] myCharArray = s.ToCharArray();

            for (int i = 0; i < myCharArray.Length; i++)
            {
                romanNumerals().TryGetValue(myCharArray[i], out int value);

                myVal = myVal + value;
            }

            return myVal;
        }

        public Dictionary<char, int> romanNumerals()
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            return myDict;
        }
    }
}
