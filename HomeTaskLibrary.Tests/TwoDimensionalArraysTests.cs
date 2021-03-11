using NUnit.Framework;
using System;

namespace HomeTaskLibrary.Tests
{
    class TwoDimensionalArraysTests
    {
        public void GetMinElementTest(int[,] array, int expected)
        {
            int actual = TwoDimensionalArrays.GetMinElement(array);
            Assert.AreEqual(expected, actual);
        }
        public void GetIndexOfMinElementTest(int[,] array, Tuple<int, int> expected ) 
        {
            Tuple<int, int> actual = TwoDimensionalArrays.GetIndexOfMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        public void GetMaxElementTest(int[,] array, int expected)
        {
            int actual = TwoDimensionalArrays.GetMaxElement(array);
            Assert.AreEqual(expected, actual);
        }
        public void GetIndexOfMaxElementTest(int[,] array, Tuple<int, int> expected)
        {
            Tuple<int, int> actual = TwoDimensionalArrays.GetIndexOfMaxElement(array);
            Assert.AreEqual(expected, actual);
        }
        public void CountElementsBiggerThanNeighborsTest(int[,] array, int expected)
        {
            int actual = TwoDimensionalArrays.CountElementsBiggerThanNeighbors(array);
            Assert.AreEqual(expected, actual);
        }
        public void GetTranspositionArrayTest(int[,] array, int[,] expected)
        {
            int[,] actual = TwoDimensionalArrays.GetTranspositionArray(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
