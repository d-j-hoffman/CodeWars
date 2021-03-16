using NUnit.Framework;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using CodeWars.WIP;
using System.Diagnostics;

namespace CodeWars
{
    public class Program
    {
    static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(BitCount.CountOnes(1, 1000000000));
            stopWatch.Stop();
            Console.WriteLine($"Time Taken: {stopWatch.Elapsed}");
            
        }
    }
}