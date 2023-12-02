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
                string xString = x.ToString();

                string xStringReversed = new string(xString.Reverse().ToArray());

                if (xStringReversed.Contains("-"))
                {
                    xStringReversed = "-" + xStringReversed.Replace("-", "");
                }

                int xIntReversed = Convert.ToInt32(xStringReversed);

                return xIntReversed;
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
                return 0;
			}
        }
    }
}
