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

            foreach (string word in words)
            {
                if (CanFormWord(word, chars))
                {
                    count += word.Length;
                }
            }

            Console.WriteLine(count);

            return count;
        }

        private bool CanFormWord(string word, string chars)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrences of each character in chars
            foreach (char c in chars)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Check if the characters in word can be formed using chars
            foreach (char c in word)
            {
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                {
                    return false;
                }

                charCount[c]--;
            }

            return true;
        }
    }
}
