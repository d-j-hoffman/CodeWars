using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.WIP
{
    class Ten_PinBowling
    {
        //https://www.codewars.com/kata/5531abe4855bcc8d1f00004c
        public static int BowlingScore(string frames)
        {

            List<string> splitFrames = frames.Split().ToList();
            int[] score = new int[10];
            string first = splitFrames[splitFrames.Count - 1];
            int[] firstScores = new int[3];
            for (int i = 0; i < first.Length; i++)
            {
                switch (first[i])
                {
                    case 'X':
                        firstScores[i] = 10;
                        break;
                    case '/':
                        firstScores[i] = 10 - firstScores[i - 1];
                        break;
                    default:
                        firstScores[i] = first[i] - 48;
                        break;
                }

            }
            score[splitFrames.Count - 1] = firstScores.Sum();
            int addPrev = firstScores[0];
            int nextPrev = firstScores[1];
            for (int i = splitFrames.Count - 2; i >= 0; i--)
            {
                if (splitFrames[i] == "X")
                {
                    score[i] += 10;
                    score[i] += addPrev;
                    score[i] += nextPrev;
                    nextPrev = addPrev;
                    addPrev = 10;
                }
                else
                {
                    int tempNextPrev;
                    int tempPrev = splitFrames[i][0] - 48;
                    score[i] += tempPrev;
                    if (splitFrames[i][1] == '/')
                    {
                        tempNextPrev = 10 - score[i];
                        score[i] += tempNextPrev;
                        score[i] += addPrev;
                        nextPrev = tempNextPrev;
                    }
                    else
                    {
                        tempNextPrev = splitFrames[i][1] - 48;
                        score[i] += tempNextPrev;
                        nextPrev = tempNextPrev;
                    }
                    addPrev = tempPrev;
                }
            }
            return score.Sum();

        }
    }
}
