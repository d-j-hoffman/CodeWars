using System.Collections.Generic;
using System.Text;
using System;
using System.Numerics;

namespace CodeWars.WIP
{
    class BitCount
    {
        //https://www.codewars.com/kata/596d34df24a04ee1e3000a25
        public static BigInteger CountOnes(long left, long right)
        {
            BigInteger total = 0;
            for(long i = left; i<=right; i++)
            {
                long currentTotal = 0, n = i;
                while(n!=0)
                {
                    n = n & (n - 1);
                    currentTotal++;
                }
                total += currentTotal;
            }
            return total;
        }
    }
}
