using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            int original = x;
            int reverse = 0;

            while (x > 0)
            {
                int y = x % 10;
                Console.WriteLine($"Num is {y}");
                reverse = reverse * 10 + y;
                Console.WriteLine($"Reverse is {reverse}");
                x = x / 10;
            }

            return original == reverse;
        }
    }
}
