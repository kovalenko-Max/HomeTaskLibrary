using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
            double[] sol = BranchingStructures.GetQuadraticEquationSolving(1, 0, 0);

            foreach(double s in sol)
            {
                Console.WriteLine(s);
            }

        }
    }
}
