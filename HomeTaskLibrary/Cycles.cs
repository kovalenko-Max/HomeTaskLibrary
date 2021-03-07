using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    public class Cycles
    {
        public static double GetDegreeOf(double a, int b)
        {
            double result = a;

            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }

            return result;
        }

        public static int[] DivisionWithoutRemainderFromZeroToThouthen(int a)
        {
            const int thousand = 1000;
            int lengt = thousand / a;
            int[] result = new int[lengt];
            int i = 0;

            for (int numb = a; numb <= thousand; numb += a)
            {
                if (numb % a == 0)
                {
                    result[i] = numb;
                    ++i;
                }
            }
            return result;
        }

        public static int GetCountOfNumbers(int a)
        {
            int i = 1;
            while ((i * i) < a)
            {
                i++;
            }
            return i - 1;
        }

        public static int GetCountOfNumbers(double a)
        {
            int i = 1;
            while ((i * i) < a)
            {
                i++;
            }
            return i - 1;
        }

        public static int GetGCD(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return a + b;
        }

        public static double GetCubeRoot(int numb)
        {
            int cubeRoot = 0;

            double start = 0;
            double end = numb;
            double error = 0.000001;
            double mid = 0;
            double cubeOfMid = 0;
            do
            {
                mid = (start + end) / 2;
                cubeOfMid = mid * mid * mid;

                if (cubeOfMid > numb)
                {
                    end = mid;
                }
                if (cubeOfMid < numb)
                {
                    start = mid;
                }
            } while (Math.Abs(numb - cubeOfMid) >= error);

            return Math.Round(mid, 6);
        }

        public static int GetCountOddDigit(int numb)
        {
            int count = 0;
            string digit = numb.ToString();

            for (int i = 0; i < digit.Length; i++)
            {
                if (digit[i] % 2 != 0) count++;
            }
            return count;
        }

        public static int GetMirrorNumb(int numb)
        {
            string digit = numb.ToString();
            StringBuilder result = new StringBuilder();

            for (int i = digit.Length - 1; i >= 0; i--)
            {
                result.Append(digit[i]);
            }
            return Convert.ToInt32(result.ToString());
        }

        public static int[] GetNumbersWhichSumOfEvenIsBiggerThanOdd(int numb)
        {
            int evenSum = 0;
            int oddSum = 0;

            int[] result = new int[numb/2];
            int j = 0;
            for (int i = 1; i <= numb; i++)
            {
                string temp = i.ToString();
                foreach (char ch in temp)
                {
                    if (ch % 2 == 0) evenSum += ch;
                    else oddSum += ch;
                }
                if (evenSum > oddSum)
                {
                    result[j] = i;
                    j++;
                }

                evenSum = 0;
                oddSum = 0;
            }

            int [] r = new int[]

            return result;

        }

    }
}
