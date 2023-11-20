using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };

            Solution solution = new Solution();
            solution.ReverseString(s);

            Console.ReadLine();
        }
    }
}
