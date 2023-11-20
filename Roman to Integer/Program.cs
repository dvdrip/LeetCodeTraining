using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roman roman = new Roman();

            string myString = Console.ReadLine();

            var myNum = roman.RomanToInt(myString);

            Console.WriteLine(myNum);

            Console.ReadLine();
        }
    }
}
