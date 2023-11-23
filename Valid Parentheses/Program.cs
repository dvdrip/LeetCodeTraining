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
            string myExit = Console.ReadLine();

            while (myExit != "out")
            {
                Solution solution = new Solution();

                bool validity = solution.IsValid(myExit);

                Console.WriteLine(validity);

                myExit = Console.ReadLine();
            }
        }
    }
}
