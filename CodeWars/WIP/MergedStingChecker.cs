using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.WIP
{
    class MergedStingChecker
    {
        //https://www.codewars.com/kata/54c9fcad28ec4c6e680011aa
        public static bool isMerge(string s, string part1, string part2)
        {
            int firstWordCounter = 0, secondWordCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                bool isChecked = false;
                if (part1.Length > firstWordCounter && c == part1[firstWordCounter])
                {
                    firstWordCounter++;
                    isChecked = true;
                }
                else if (part2.Length > secondWordCounter && c == part2[secondWordCounter])
                {
                    secondWordCounter++;
                    isChecked = true;
                }
                if (!isChecked)
                    return false;
            }
            return true;
        }
    }
}
