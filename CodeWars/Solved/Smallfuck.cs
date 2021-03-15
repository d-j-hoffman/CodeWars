using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class Smallfuck
    {
        //https://www.codewars.com/kata/58678d29dbca9a68d80000d7
        public static string Interpreter(string code, string tape)
        {
            //INSTRUCTIONS:
            // (>) - Move pointer to the right by one cell
            // (<) - Move pointer to the left by one cell
            // (*) - Flip the bit at the current cell
            // ([) - Jump past matching (]) if value at current cell is 0
            // (]) - Jump back to matching ([) if value at current cell is not 0
            int tapePointer = 0;
            int codePointer = 0;
            int loopCounter = 0;
            StringBuilder sbTape = new StringBuilder(tape);
            //Break if the tapePointer goes off the tape.
            while (tapePointer >= 0 && tapePointer < tape.Length)
            {
                if (codePointer == code.Length)
                {
                    //Finished reading the code, return the modified tape.
                    return sbTape.ToString();
                }
                //Flip the bit at the current cell
                if (code[codePointer] == '*')
                {
                    if (sbTape[tapePointer] == '0')
                        sbTape[tapePointer] = '1';
                    else
                        sbTape[tapePointer] = '0';
                }
                //Move pointer to the right
                else if (code[codePointer] == '>')
                    tapePointer++;
                //Move pointer to the left
                else if (code[codePointer] == '<')
                    tapePointer--;
                //Move codePointer PAST matching ]
                else if (code[codePointer] == '[' && sbTape[tapePointer] == '0')
                {
                    loopCounter++;
                    while (loopCounter != 0)
                    {
                        codePointer++;
                        //An inner loop has been found, increment loop counter
                        if (code[codePointer] == '[')
                            loopCounter++;
                        //A loop has closed, if this is our loop loopCounter == 0
                        else if (code[codePointer] == ']')
                            loopCounter--;

                    }


                }
                //Move codePointer back to matching [
                else if (code[codePointer] == ']' && sbTape[tapePointer] != '0')
                {
                    loopCounter++;
                    while (loopCounter != 0)
                    {
                        codePointer--;
                        //An inner loop has been found, increment loop counter
                        if (code[codePointer] == ']')
                            loopCounter++;
                        //A loop has closed, if this is our loop loopCounter == 0
                        else if (code[codePointer] == '[')
                            loopCounter--;
                    }
                }
                //Move to next code
                if (codePointer < code.Length)
                    codePointer++;
            }
            return sbTape.ToString();
        }
    }
}
