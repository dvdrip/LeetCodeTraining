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

            for (int i = 0; i < n + 1; i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case int num when num % 3 == 0 && num % 5 == 0:
                        stringList.Add("FizzBuzz");
                        break;
                    case int num when num % 3 == 0:
                        stringList.Add("Fizz");
                        break;
                    case int num when num % 5 == 0:
                        stringList.Add("Buzz");
                        break;
                    case int num when num <= n:
                        stringList.Add(i.ToString());
                        break;
                    default:
                        break;
                }
            }
            return stringList;
        }

        public IList<string> FizzBuzz2(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
