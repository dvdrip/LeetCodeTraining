using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1160.Find_Words_That_Can_Be_Formed_by_Characters
{
    internal class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            int count = 0;

            string uniqueLetters = new string(chars.Distinct().ToArray());

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < uniqueLetters.Length; j++)
                {
                    if (words[i].Contains(chars[j]))
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            Console.WriteLine(count);

            return count;
        }
    }
}
