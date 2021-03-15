using NUnit.Framework;
using System;

namespace HomeTaskLibrary.Tests
{
    class TwoDimensionalArraysTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        public void GetMinElement_WhenArray_ShouldGetMinElement(int arrayNumb, int expected)
        {
            int actual = TwoDimensionalArrays.GetMinElement(TwoDimensionalArraysMock.GetMock(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(2, 0, 0)]
        public void GetIndexOfMinElement_WhenArray_ShouldGetIndexOfMinElement(int arrayNumb, int expectedI, int expectedJ)
        {
            Tuple<int, int> actual = TwoDimensionalArrays.GetIndexOfMinElement(TwoDimensionalArraysMock.GetMock(arrayNumb));
            int actualI = actual.Item1;
            int actualJ = actual.Item2;
            Assert.AreEqual(expectedI, actualI);
            Assert.AreEqual(expectedJ, actualJ);
        }

        [TestCase(1, 9)]
        [TestCase(2, 50)]
        public void GetMaxElement_WhenArray_ShouldGetMaxElement(int arrayNumb, int expected)
        {
            int actual = TwoDimensionalArrays.GetMaxElement(TwoDimensionalArraysMock.GetMock(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 0)]
        [TestCase(2, 0, 1)]
        public void GetIndexOfMaxElement_WhenArray_ShouldGetIndexOfMaxElement(int arrayNumb, int expectedI, int expectedJ)
        {
            Tuple<int, int> actual = TwoDimensionalArrays.GetIndexOfMaxElement(TwoDimensionalArraysMock.GetMock(arrayNumb));
            int actualI = actual.Item1;
            int actualJ = actual.Item2;
            Assert.AreEqual(expectedI, actualI);
            Assert.AreEqual(expectedJ, actualJ);
        }

        [TestCase(1, 2)]
        public void CountElementsBiggerThanNeighborsTest(int arrayNumb, int expected)
        {
            int actual = TwoDimensionalArrays.CountElementsBiggerThanNeighbors(TwoDimensionalArraysMock.GetMock(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3)]
        public void GetTranspositionArrayTest(int arrayNumb, int expectedArrayNumb)
        {
            int[,] actual = TwoDimensionalArrays.GetTranspositionArray(TwoDimensionalArraysMock.GetMock(arrayNumb));
            Assert.AreEqual(TwoDimensionalArraysMock.GetMock(expectedArrayNumb), actual);
        }
    }

    public static class TwoDimensionalArraysMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 9, 0, 0 }
                    };
                    break;

                case 2:
                    result = new int[,]
                    {
                    { 1, 50, 3 },
                    { 8, 5, 6 }
                    };
                    break;

                case 3:
                    result = new int[,]
                    {
                    { 1, 8 },
                    { 50, 5 },
                    { 3, 6 }
                    };
                    break;
            }

            return result;
        }
    }
}
