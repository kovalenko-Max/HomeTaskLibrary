using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double x1 = 999999999999999999;
            double y1 = 999999999999999999;
            double x2 = 0;
            double y2 = 999999999999999999;

            (a, b) = Variables.GetCoordinateQuarter(x1, y1, x2, y2);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
