using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1160.Find_Words_That_Can_Be_Formed_by_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cat", "bt", "hat", "tree" };
            string target = "atach";

            Solution solution = new Solution();
            var x = solution.CountCharacters(words, target);

            Console.ReadLine();
        }
    }
}
