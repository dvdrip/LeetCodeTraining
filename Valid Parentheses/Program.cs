using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Solution solution = new Solution();
            
            bool validity = solution.IsValid(s);

            Console.WriteLine(validity);

            Console.ReadLine();
        }
    }
}
