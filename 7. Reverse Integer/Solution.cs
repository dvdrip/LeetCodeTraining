using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Reverse_Integer
{
    internal class Solution
    {
        public int Reverse(int x)
        {
			try
			{
                bool isNegative = x < 0;

                string xString = Convert.ToInt64(x).ToString();

                string xStringReversed = new string(xString.Reverse().ToArray());

                int xIntReversed = Convert.ToInt32(xStringReversed);

                return isNegative ? -xIntReversed : xIntReversed;
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                return 0;
			}
        }
    }
}
