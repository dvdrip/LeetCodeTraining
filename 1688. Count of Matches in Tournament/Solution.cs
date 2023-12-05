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
            int answer = 0;

            if (n % 2 == 0)
            {
                Console.WriteLine(n);
                //if even
                while (n != 1)
                {
                    n = n / 2;
                    Console.WriteLine(n);

                    answer = answer + n;
                }
            }
            else
            {
                //if odd

            }

            return answer;
        }
    }
}
