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
            string[] myStrings = { "flow", "floght", "flo", "flower", "flought"};

            Solution solution = new Solution();

            solution.TryAnother(myStrings);

            Console.ReadLine();
        }
    }
}
