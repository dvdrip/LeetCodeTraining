using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412.Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            Solution solution = new Solution();

            foreach (var item in solution.FizzBuzz(n))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
