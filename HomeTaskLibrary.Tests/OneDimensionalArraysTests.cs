using NUnit.Framework;
namespace HomeTaskLibrary.Tests
{
    class OneDimensionalArraysTests
    {
        public void GetMaxElementOfArrayTests(int[] array, int expected) 
        {
            int actual = OneDimensionalArrays.GetMaxElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }

        public void GetMinElementOfArrayTests(int[] array, int expected) 
        {
            int actual = OneDimensionalArrays.GetMinElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        
        public void GetIndexOfMaxElementOfArrayTests(int[] array, int expected) 
        {
            int actual = OneDimensionalArrays.GetIndexOfMaxElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }

        public void GetIndexOfMinElementOfArrayTests(int[] array, int expected) 
        {
            int actual = OneDimensionalArrays.GetIndexOfMinElementOfArray(array);
            Assert.AreEqual(expected, actual);
        }

        public void GetSumOddTests(int[] array, int expected) 
        {
            int actual = OneDimensionalArrays.GetSumOdd(array);
            Assert.AreEqual(expected, actual);
        }

        public void ReverseArrayTests(int[] array, int[] expected) 
        {
            int[] actual = OneDimensionalArrays.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        }

        public void GetCountOfOddElementsTests(int[] array, int expected)
        {
            int actual = OneDimensionalArrays.GetCountOfOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        public void ChangeHalfsOfArrayTests(int[] array, int[] expected) 
        {
            int[] actual = OneDimensionalArrays.ChangeHalfsOfArray(array);
            Assert.AreEqual(expected, actual);
        }
        public void SortAscendingTests(int[] array, int[] expected) 
        {
            int[] actual = OneDimensionalArrays.SortAscending(array);
            Assert.AreEqual(expected, actual);
        }
        public void SortDescendingTests(int[] array, int[] expected) 
        {
            int[] actual = OneDimensionalArrays.SortDescending(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
