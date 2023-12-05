using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67.Add_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "11";
            string y = "1";

            Solution solution = new Solution();
            var xyz = solution.AddBinary(x, y);

            Console.WriteLine(xyz);
            Console.ReadLine();
        }
    }
}
