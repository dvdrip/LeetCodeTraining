using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StackTest
    {
        public bool Stacker(string myStr)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char item in myStr)
            {
                stack.Push(item);

                if (stack.Count == 0)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
