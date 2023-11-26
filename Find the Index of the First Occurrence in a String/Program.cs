using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "225sadbutsad";
            string needle = "sad";

            Solution solution = new Solution();
            int myIndex = solution.StrStr(haystack, needle);

            Console.WriteLine(myIndex);

            Console.ReadLine();
        }
    }
}
