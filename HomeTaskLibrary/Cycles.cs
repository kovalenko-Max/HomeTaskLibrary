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

        public static int GetCountOfsquareNumberLessThanA(int a)
        {
            int i = 1;
            while ((i * i) < a)
            {
                i++;
            }
            return i - 1;
        }

        public static int GetCountOfsquareNumberLessThanA(double a)
        {
            int i = 1;
            while ((i * i) < a)
            {
                i++;
            }
            return i - 1;
        }

        public static int GreatestDivisor(int a)
        {
            int result = a;
            for (int i = a-1; i > 0; --i)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static int GetSumOfNumbDivisionBySeven(int a, int b)
        {
            int result = 0;

            if (a != b) 
            {
                if (a < b)
                {                    
                    for (int i = a+1; i < b; i++)
                    {
                        if (i % 7 == 0)
                        {
                            result += i;
                        }
                    }
                }
                else
                {
                    for(int i = b+1; i < a; i++)
                    {
                        if (i % 7 == 0)
                        {
                            result += i;
                        }
                    }
                }
            }
            return result;
        }

        public static int GetFibNumb(int n)
        {
            int result = 0;

            if (n > 2)
            {
                int[] fibNumb = new int[n];
                fibNumb[0] = 1;
                fibNumb[1] = 1;

                for (int i = 2; i < n; ++i)
                {
                    fibNumb[i] = fibNumb[i - 1] + fibNumb[i - 2];
                }
                result = fibNumb[n - 1];
            }
            else
            {
                result = 1;
            }

            return result;
        }
    }
}
