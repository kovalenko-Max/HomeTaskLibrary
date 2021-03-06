using NUnit.Framework;
using System;

namespace HomeTaskLibrary.Tests
{
    public class BranchingStructuresTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, -1)]
        [TestCase(25, 25, 625)]
        [TestCase(9999999, 9999999, 99999980000001)]
        public void CalculateAB_WhenAandBShould_BeCalculated(double a, double b, double expected)
        {
            double actual = BranchingStructures.CalculateAB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(50, 3, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(-9999, -25, 3)]
        [TestCase(-999999999, 25, 2)]
        [TestCase(25, -100000000, 4)]
        public void GetQuarter_WhenXandY_ShouldGetQuater(double x, double y, int expected)
        {
            int actual = BranchingStructures.GetQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 3, 6, 3, 6, 25)]
        [TestCase(0, 0, 1, 0, 0, 1)]
        [TestCase(0, 1, 0, 0, 0, 1)]
        [TestCase(1, 1, 1.00000001, 1, 1, 1.00000001)]
        public void SortThreeVariables_WhenABC_ShouldBeAscending(double a, double b, double c,
            double expectedA, double expectedB, double expectedC)
        {
            BranchingStructures.SortThreeVariables(ref a, ref b, ref c);
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
            Assert.AreEqual(expectedC, c);
        }

        [TestCase(2, 4, 0, new double[] { -2, 0 })]
        [TestCase(1, 0, 0, new double[] { 0 })]
        [TestCase(5, 0, 3, new double[] { })]
        public void GetQuadraticEquationSolving_WhenABC_ShouldSolvQuadraticEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = BranchingStructures.GetQuadraticEquationSolving(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5 , 5)]
        public void GetQuadraticEquationSolving_WhenAEquals0_ShouldThrowArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => BranchingStructures.GetQuadraticEquationSolving(a, b, c));
        }

        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(19, "nineteen")]
        [TestCase(25, "twenty-five")]
        [TestCase(50, "fifty")]
        [TestCase(99, "ninety-nine")]
        [TestCase(20, "twenty")]
        [TestCase(80, "eighty")]

        public void NumpToTextWhenNumbShouldBeString(int numb, string expected)
        {
            string actual = BranchingStructures.NumpToText(numb);
        }
    }
}
