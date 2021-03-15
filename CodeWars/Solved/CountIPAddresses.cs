using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class CountIPAddresses
    {
        //https://www.codewars.com/kata/526989a41034285187000de4
        /// <summary>
        /// Count the IP Addresses between two passed Addresses.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static long IpsBetween(string start, string end)
        {
            long total = 0;
            int multiplier = 1;
            string[] first = start.Split('.');
            string[] second = end.Split('.');
            for (int i = 3; i >= 0; i--)
            {
                total += multiplier * (int.Parse(second[i]) - int.Parse(first[i]));
                multiplier *= 256;
            }

            return total;
        }
    }
}
