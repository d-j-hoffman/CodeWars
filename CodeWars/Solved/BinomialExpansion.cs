using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Solved
{
    class BinomialExpansion
    {
        //https://www.codewars.com/kata/540d0fdd3b6532e5c3000b5b
        public static string Expand(string expr)
        {
            Regex regExpression = new Regex(@"^\((-?\d*)(\w)((\+|-){1,1}\d*)\)\^(.*?)$");
            string[] stringArr = (regExpression.Replace(expr, "$1 $2 $3 $5")).Split();
            switch (stringArr[0])
            {
                case "":
                    stringArr[0] = "1";
                    break;
                case "-":
                    stringArr[0] = "-1";
                    break;
            }
            if (stringArr[2] == "")
                stringArr[2] = "1";
            double a = double.Parse(stringArr[0]), b = double.Parse(stringArr[2]), n = double.Parse(stringArr[3]);
            char x = stringArr[1][0];
            if (n == 0)
                return "1";
            string returnString = "";
            double multiplier = 1;
            double max = n;
            for (int i = 0; i <= max; i++)
            {
                if (i == 0 || i == max)
                    multiplier = 1;
                else
                    multiplier = multiplier * (max - i + 1) / i;
                double secondExponent = max - n;
                double firstPart = Math.Pow(a, n) * multiplier;
                double secondPart = Math.Pow(b, secondExponent);
                if (i > 0 && firstPart * secondPart > 0)
                    returnString += "+";
                string value = $"{firstPart * secondPart}";
                if (int.Parse(value) == 0)
                    continue;
                if (n > 1)
                {
                    if (value == "1" || value == "0" || value == "-0")
                        value = "";
                    else if (value == "-1")
                        value = "-";
                    returnString += $"{value}{x}^{n}";
                }

                else if (n == 1)
                {
                    if (value == "0")
                        value = "~";
                    if (value == "1")
                        value = "";
                    else if (value == "-1")
                        value = "-";
                    if (value != "~")
                        returnString += $"{value}{x}";
                }
                else
                {
                    if (value == "0")
                        value = "";
                    returnString += $"{value}";
                }


                n--;
            }

            return returnString;

        }
    }
}
