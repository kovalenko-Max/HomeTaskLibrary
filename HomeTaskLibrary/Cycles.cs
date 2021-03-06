using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    public class Cycles
    {
        public static double degreeOf(double a, int b)
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
    }
}
