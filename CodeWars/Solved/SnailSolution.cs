using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class SnailSolution
    {
        //https://www.codewars.com/kata/snail
        public static int[] Snail(int[][] array)
        {
            //array = [ [1,2,3],
            //          [4,5,6],
            //          [7,8,9]]
            //
            //snail(array) #=> [1,2,3,6,9,8,7,4,5]

            List<int> returnArray = new List<int>();
            bool[] bordersBool = new bool[4] { true, false, false, false };
            int[] borders = new int[] { 0, array[0].Length - 1, array.Length - 1, 0 };
            int total = array.Length * array[0].Length;
            int currentX = 0, currentY = 0;
            if (array[0].Length > 0)
                returnArray.Add(array[currentY][currentX]);
            while (returnArray.Count < total)
            {
                if (bordersBool[0])
                {
                    currentX++;
                    if (currentX >= borders[1])
                    {
                        borders[0]++;
                        bordersBool[0] = false;
                        bordersBool[1] = true;
                    }
                }
                else if (bordersBool[1])
                {
                    currentY++;
                    if (currentY >= borders[2])
                    {
                        borders[1]--;
                        bordersBool[1] = false;
                        bordersBool[2] = true;
                    }
                }
                else if (bordersBool[2])
                {
                    currentX--;
                    if (currentX <= borders[3])
                    {
                        borders[2]--;
                        bordersBool[2] = false;
                        bordersBool[3] = true;
                    }
                }
                else if (bordersBool[3])
                {
                    currentY--;
                    if (currentY <= borders[0])
                    {
                        borders[3]++;
                        bordersBool[3] = false;
                        bordersBool[0] = true;
                    }
                }
                returnArray.Add(array[currentY][currentX]);
            }
            return returnArray.ToArray();
        }
}
