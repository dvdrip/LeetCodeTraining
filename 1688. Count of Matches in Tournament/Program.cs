﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1688.Count_of_Matches_in_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teams = 14;

            Solution solution = new Solution();
            int matchesLeft = solution.NumberOfMatches(teams);
            Console.WriteLine(matchesLeft);
            Console.ReadLine();
        }
    }
}
