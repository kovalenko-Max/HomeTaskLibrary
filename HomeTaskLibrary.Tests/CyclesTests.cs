using NUnit.Framework;

namespace HomeTaskLibrary.Tests
{
    class CyclesTests
    {
        public void GetDegreeOfTests(int a, int b, int expected)
        {
            int actual = Cycles.GetDegreeOf(a, b);
            Assert.AreEqual(expected, actual);
        }

        public void DivisionWithoutRemainderFromZeroToThouthenTests(int a, int[] expected)
        {
            int[] actual = Cycles.DivisionWithoutRemainderFromZeroToThouthen(a);
            Assert.AreEqual(expected, actual);
        }

        public void GetCountOfsquareNumberLessThanATests(int a, int expected)
        {
            int actual = Cycles.GetCountOfsquareNumberLessThanA(a);
            Assert.AreEqual(expected, actual);
        }

        public void GreatestDivisorTests(int a, int expected)
        {
            int actual = Cycles.GreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        public void GetSumOfNumbDivisionBySevenTests(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbDivisionBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }

        public void GetFibNumbTests(int n, int expected)
        {
            int actual = Cycles.GetFibNumb(n);
            Assert.AreEqual(expected, actual);
        }

        public void GetGCDTests(int a, int b, int expected)
        {
            int actual = Cycles.GetGCD(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(0, 0)]
        public void GetCubeRootTests(int n, double expected)
        {
            double actual = Cycles.GetCubeRoot(n);
            Assert.AreEqual(expected, actual);
        }

        public void GetCountOddDigitTests(int n, int expected)
        {
            int actual = Cycles.GetCountOddDigit(n);
            Assert.AreEqual(expected, actual);
        }

        public void GetMirrorNumbTests(int n, int expected)
        {
            int actual = Cycles.GetMirrorNumb(n);
            Assert.AreEqual(expected, actual);
        }

        public void GetNumbersWhichSumOfEvenIsBiggerThanOddTests(int numb, int[] expected)
        {
            int[] actual = Cycles.GetNumbersWhichSumOfEvenIsBiggerThanOdd(numb);
            Assert.AreEqual(expected, actual);
        }

        public void IsIdenticalDigitsInNumbersTests(int numb1, int numb2, bool expected)
        {
            bool actual = Cycles.IsIdenticalDigitsInNumbers(numb1, numb2);
            Assert.AreEqual(expected, actual);
        }

    }
}
