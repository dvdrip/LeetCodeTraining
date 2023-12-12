using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.Sqrt_x_
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            double y = Math.Sqrt(x);
            int z = (int)Math.Floor(y);

            return z;
        }
    }
}
