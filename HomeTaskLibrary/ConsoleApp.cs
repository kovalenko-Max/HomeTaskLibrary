using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
            int numb = 64;

            Console.WriteLine(Cycles.GetNumbersWhichSumOfEvenIsBiggerThanOdd(numb));

        }
    }
}
