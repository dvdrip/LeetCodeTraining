using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = { "flow", "flight", "fly", "flower" };

            Solution solution = new Solution();

            solution.LongestCommonPrefix(myStrings);

            Console.ReadLine();
        }
    }
}
