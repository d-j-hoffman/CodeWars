using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.WIP
{
    public class MergedStingChecker
    {
        //https://www.codewars.com/kata/54c9fcad28ec4c6e680011aa
        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length == 0)
            {
                if (part1.Length + part2.Length > 0)
                    return false;
                return true;
            }
            if(part1.Length > 0 && s[0] == part1[0])
            {
                if (isMerge(s.Substring(1), part1.Substring(1), part2))
                    return true;
            }
            if(part2.Length >0 && s[0] == part2[0])
            {
                if (isMerge(s.Substring(1), part1, part2.Substring(1)))
                    return true;
            }

            return false;
        }
    }
}
