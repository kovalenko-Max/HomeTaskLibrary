using System;

namespace HomeTaskLibrary
{
    public class Variables
    {
        public static double CalculateEquation(double a, double b)
        {
            if (b == a)
            {
                throw new DivideByZeroException();
            }

            return (5 * a + b * b) / (b - a);
        }

        public static int[] Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            int[] result = new int[2];
            result[0] = a / b;
            result[1] = a % b;
            return result;
        }

        public static double CalculateSolutionOfLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            return (c - b) / a;
        }

        public static (double, double) GetCoordinateQuarter(double x1, double y1, double x2, double y2)
        {
            if(x1 != x2)
            {
                double a = (y1 - y2) / (x1 - x2);
                double b = y1 - x1 * a;
                return (a, b);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static void Swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }
        
        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
