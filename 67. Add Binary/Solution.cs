using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.Add_Binary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int firstNum = Convert.ToInt32(a);
            int secondNum = Convert.ToInt32(b);

            int sumNum = firstNum + secondNum;

            string sumBinary = Convert.ToString(sumNum, 2);

            return sumBinary;
        }
    }
}
