using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int myNum = 12321;

            Palindrome palindrome = new Palindrome();

            var myBool = palindrome.IsPalindrome(myNum);

            Console.WriteLine(myBool);

            Console.ReadLine();
        }

    }
}
