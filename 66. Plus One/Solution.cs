using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    internal class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int fullInt = Convert.ToInt32(string.Join("", digits));

            fullInt++;

            char[] resultChar = fullInt.ToString().ToArray();

            int[] resultArray = resultChar.Select(x => int.Parse(x.ToString())).ToArray();

            return resultArray;
        }
    }
}
