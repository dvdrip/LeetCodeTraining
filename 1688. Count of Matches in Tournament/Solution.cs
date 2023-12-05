using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1688.Count_of_Matches_in_Tournament
{
    public class Solution
    {
        public int NumberOfMatches(int n)
        {
            int matches = 0;
            while (n > 1)
            {
                matches += n / 2;
                n = (n + 1) / 2; // calculate the number of teams in the next round
            }
            return matches;
        }
    }
}
