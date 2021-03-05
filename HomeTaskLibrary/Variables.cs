using System;

namespace HomeTaskLibrary
{
    public class Variables
    {
        public static double CalculateEquation(int a, int b)
        {
            if (b == a)
            {
                throw new DivideByZeroException();
            }

            return (5 * a + b * b) / (b - a);
        }

        public static void swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        public static string division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return "a/b = " + a / b + " \nRemainder of the division = " + a % b;
        }

        public static double CalculateLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            return (c - b) / a;
        }

        public static Tuple<double, double> GetCoordinateQuarter(double x1, double y1, double x2, double y2)
        {
            string result = string.Empty;
            double a = 0;
            double b = 0;
            a = (y1 - y2) / (x1 - x2);
            b = y1 - x1 * a;

            return Tuple.Create(a, b);
        }
    }
}
