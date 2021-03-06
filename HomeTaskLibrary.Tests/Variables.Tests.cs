using NUnit.Framework;
using System;

namespace HomeTaskLibrary.Tests
{
    public class VariablesTest
    {
        [TestCase(5, 6, 61)]
        [TestCase(255, 5, -5.2)]
        [TestCase(200025, 1516156, 1746581.4698240524)]
        [TestCase(0, 1, 1)]
        public void CalculateEquation_WhenAandB_ShouldBeCalculated(double a, double b, double expected)
        {
            double actual = Variables.CalculateEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,5)]
        public void CalculateEquation_WhenAEqualsB_ShouldThrowArgumentException(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => Variables.CalculateEquation(a, b));
        }
        
        [TestCase(0.1, 0.25, 0.25, 0.1)]
        [TestCase(1, 0, 0, 1)]
        [TestCase(5.4, 6.2, 6.2, 5.4)]
        [TestCase(7, 12, 12, 7)]
        [TestCase(0, 0, 0, 0)]
        public void Swap_When_DoubleAandB_ShouldBecameBAndA(double a, double b, double expectedA, double expectedB)
        {
            Variables.Swap(ref a, ref b);
            expectedA = a;
            expectedB = b;
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [TestCase(5, 6, 6, 5)]
        [TestCase(7, 12, 12, 7)]
        [TestCase(10, 6, 6, 10)]
        [TestCase(0, 0, 0, 0)]
        public void Swap_WhenIntAandB_ShouldBecameBAndA(int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);
            expectedA = a;
            expectedB = b;
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }
        
        [TestCase(255, 5, new int[] { 51, 0 })]
        [TestCase(0, 5, new int[] { 0, 0 })]
        [TestCase(100000000, 5, new int[] { 20000000, 0 })]
        public void Division_WhetAAndB_ShouldReturnArray(int a, int b, int[] expected)
        {
            int[] actual = Variables.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,0)]
        public void Division_WhenBEquals0_ShouldThrowDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.Division(a, b));
        }

        [TestCase(13, 5, 255, 19.23076923076923)]
        [TestCase(1, 0.25, 999999999, 999999998.75)]
        [TestCase(500, 0.0005, 1, 0.001999)]

        public void CalculateSolutionOfLinearEquation_WhenAandBandC_SouldBeSolution(double a, double b, double c, double expected)
        {
            double actual = Variables.CalculateSolutionOfLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 1)]
        public void CalculateSolutionOfLinearEquation_WhenAEquals0_ShouldThrowDivideByZeroException(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.CalculateSolutionOfLinearEquation(a, b, c));
        }

        [TestCase(1.4, 25, 10, 26, 0.11627906976744186, 24.837209302325583)]
        [TestCase(1, 1, 999999999999999999, 1, 0, 1)]
        [TestCase(999999999999999999, 999999999999999999, 0, 999999999999999999, 0, 1E+18)]
        public void GetCoordinateQuarter_WhenX1Y1X2Y2_ShouldBeLenearEquation(double x1, double y1, double x2, double y2, double expectedA, double expectedB)
        {
            Tuple<double, double> actual = Variables.GetCoordinateQuarter(x1, y1, x2, y2);
            double actualA = actual.Item1;
            double actualB = actual.Item2;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }
        
        [TestCase(5,10, 5, 10)]
        public void GetCoordinateQuarter_WhenX1EqualsX2_ShouldThrowArgumentException(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetCoordinateQuarter(x1, y1, x2, y2));
        }

    }
}