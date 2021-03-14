using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    public class BranchingStructures
    {
        public static double CalculateAB(double a, double b)
        {
            double result = 0;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else if (a < b)
            {
                result = a - b;
            }

            return result;
        }

        public static int GetQuarter(double x, double y)
        {
            int result = 0;
            if (x == 0 || y == 0)
            {
                result = 0;
            }
            else if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x > 0 && y < 0)
            {
                result = 4;
            }

            return result;
        }

        public static void SortThreeVariables(ref double a, ref double b, ref double c)
        {
            if (a > c)
            {
                Variables.Swap(ref a, ref c);
            }
            if (a > b)
            {
                Variables.Swap(ref a, ref b);
            }
            if (b > c)
            {
                Variables.Swap(ref b, ref c);
            }
        }

        public static double[] GetQuadraticEquationSolving(double a, double b, double c)
        {
            double[] results;
            double discriminant = b * b - 4 * a * c;

            if (a == 0)
            {
                throw new ArgumentException("a == 0. It`s not a Quadratic Equation");
            }
            if (discriminant < 0)
            {
                results = new double[0];
            }
            else if (discriminant > 0)
            {
                results = new double[2];
                results[0] = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                results[1] = ((-b + Math.Sqrt(discriminant)) / (2 * a));
            }
            else
            {
                results = new double[1];
                results[0] = (-b / (2 * a));
            }
            return results;
        }

        public static string NumpToText(int numb)
        {
            if (numb >= 10)
            {
                StringBuilder outputText = new StringBuilder();
                Dictionary<int, string> dictonary = GetDictonaryNumbToString();

                if (numb < 20)
                {
                    outputText.Append(dictonary[numb]);
                }
                else
                {
                    const int ten = 10;
                    int tens = (numb / ten) * ten;
                    int units = numb % ten;

                    outputText.Append(dictonary[tens]);

                    if (units != 0)
                    {
                        outputText.Append("-");
                        outputText.Append(dictonary[units]);
                    }
                }

                return outputText.ToString();
            }
            else
            {
                throw new ArgumentException();
            }
            {
                throw new ArgumentException();
            }

            Dictionary<int, string> GetDictonaryNumbToString()
            {
                Dictionary<int, string> dictonary = new Dictionary<int, string>();

                dictonary.Add(1, "one");
                dictonary.Add(2, "two");
                dictonary.Add(3, "three");
                dictonary.Add(4, "four");
                dictonary.Add(5, "five");
                dictonary.Add(6, "six");
                dictonary.Add(7, "seven");
                dictonary.Add(8, "eight");
                dictonary.Add(9, "nine");

                dictonary.Add(10, "ten");
                dictonary.Add(11, "eleven");
                dictonary.Add(12, "twelve");
                dictonary.Add(13, "thirteen");
                dictonary.Add(14, "fourteen");
                dictonary.Add(15, "fifteen");
                dictonary.Add(16, "sixteen");
                dictonary.Add(17, "seventeen");
                dictonary.Add(18, "eighteen");
                dictonary.Add(19, "nineteen");

                dictonary.Add(20, "twenty");
                dictonary.Add(30, "thirty");
                dictonary.Add(40, "forty");
                dictonary.Add(50, "fifty");
                dictonary.Add(60, "sixty");
                dictonary.Add(70, "seventy");
                dictonary.Add(80, "eighty");
                dictonary.Add(90, "ninety");

                return dictonary;
            }
        }
    }
}
