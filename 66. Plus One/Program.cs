using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] myInt = { 9, 8, 7, 6, 5 };

            foreach (var item in solution.PlusOne(myInt)) {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
