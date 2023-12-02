using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -123;

            Solution solution = new Solution();

            Console.WriteLine(solution.Reverse(x));

            Console.ReadLine();
        }
    }
}
