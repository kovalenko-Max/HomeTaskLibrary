using NUnit.Framework;
using System;

namespace HomeTaskLibrary.Tests
{
    class CyclesTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(4, 2, 16)]
        [TestCase(1, 10, 1)]
        [TestCase(9, 0, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 8, 0)]
        [TestCase(-5, 3, -125)]
        public void GetDegreeOf_WhenAAndB_SholdARaiseToPowerB(int a, int b, int expected)
        {
            int actual = Cycles.GetDegreeOf(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(-500, new int[] { 500, 1000 })]
        public void DivisionWithoutRemainderFromZeroToThouthen_WhenA_ShouldReturnArray(int a, int[] expected)
        {
            int[] actual = Cycles.DivisionWithoutRemainderFromZeroToThouthen(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void DivisionWithoutRemainderFromZeroToThouthen_WhenAEquals0_ShouldThrowDivideByZeroException(int a)
        {
            Assert.Throws<DivideByZeroException>(() => Cycles.DivisionWithoutRemainderFromZeroToThouthen(a));
        }

        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(25, 4)]
        [TestCase(-25, 0)]
        public void GetCountOfsquareNumberLessThanA_WhenA_ShouldReturnCount(int a, int expected)
        {
            int actual = Cycles.GetCountOfsquareNumberLessThanA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(32, 16)]
        [TestCase(1, 1)]
        [TestCase(1000, 500)]
        [TestCase(-1000, 500)]
        public void GreatestDivisor_WhenA_ShouldReturnGreatestDivisor(int a, int expected)
        {
            int actual = Cycles.GreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GreatestDivisor_WhenA_ShoulThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycles.GreatestDivisor(a));
        }


        [TestCase(1, 14, 7)]
        [TestCase(14, 1, 7)]
        [TestCase(14, 7, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(1000, 1000, 0)]
        [TestCase(-3, 14, 7)]
        [TestCase(-14, 1, -7)]
        public void GetSumOfNumbDivisionBySeven_WhenAAndB_ShouldReturnSum(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbDivisionBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void GetFibNumb_WhenN_ShouldReturnFibNumber(int n, int expected)
        {
            int actual = Cycles.GetFibNumb(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5)]
        [TestCase(-15)]
        public void GetFibNumb_WhenN_ShoulThrowArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => Cycles.GetFibNumb(n));
        }

        [TestCase(180, 150, 30)]
        [TestCase(150, 180, 30)]
        [TestCase(0, 180, 180)]
        [TestCase(150, 0, 150)]
        [TestCase(0, 0, 0)]
        [TestCase(-180, 150, 30)]
        public void GetGCD_WhenAAndB_ShouldReturnGCD(int a, int b, int expected)
        {
            int actual = Cycles.GetGCD(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(0, 0)]
        [TestCase(255, 6.3413259999999996d)]
        public void GetCubeRoot_WhenN_ShouldReturnCubicRoot(int n, double expected)
        {
            double actual = Cycles.GetCubeRoot(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2615, 2)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(22, 0)]
        [TestCase(15, 2)]
        [TestCase(-2615, 2)]
        public void GetCountOddDigit_WhenN_ShouldReturnCountOddDigit(int n, int expected)
        {
            int actual = Cycles.GetCountOddDigit(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(0, 0)]
        [TestCase(5556, 6555)]
        [TestCase(123123, 321321)]
        [TestCase(123123, 321321)]
        public void GetMirrorNumb_WhenN_ShouldReturnMirrorNumb(int n, int expected)
        {
            int actual = Cycles.GetMirrorNumb(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { })]
        [TestCase(1, new int[] { })]
        [TestCase(2, new int[] { 2 })]
        [TestCase(10, new int[] { 2, 4, 6, 8 })]
        public void GetNumbersWhichSumOfEvenIsBiggerThanOdd_WhenN_ShouldReturnArray(int numb, int[] expected)
        {
            int[] actual = Cycles.GetNumbersWhichSumOfEvenIsBiggerThanOdd(numb);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 25, true)]
        [TestCase(0, 0, true)]
        [TestCase(123, 3456789, true)]
        [TestCase(123, 0, false)]
        [TestCase(-123, 55551555, true)]
        public void IsIdenticalDigitsInNumbers_WhenAAndB_ShouldReturnBool(int numb1, int numb2, bool expected)
        {
            bool actual = Cycles.IsIdenticalDigitsInNumbers(numb1, numb2);
            Assert.AreEqual(expected, actual);
        }
    }
}
