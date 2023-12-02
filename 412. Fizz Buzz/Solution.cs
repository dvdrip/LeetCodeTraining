using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412.Fizz_Buzz
{
    internal class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> stringList = new List<string>();

            for (int i = 1; i < n + 1; i++)
            {
                switch (i)
                {
                    case int num when num % 3 == 0:
                        stringList.Add("Fizz");
                        break;
                    case int num when num % 5 == 0:
                        stringList.Add("Buzz");
                        break;
                    case int num when num < n:
                        stringList.Add(i.ToString());
                        break;
                    default:
                        break;
                }
            }
            return stringList;
        }
    }
}
