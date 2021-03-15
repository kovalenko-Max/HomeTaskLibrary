using NUnit.Framework;
namespace HomeTaskLibrary.Tests
{
    class OneDimensionalArraysTests
    {
        [TestCase(1, 74)]
        [TestCase(2, 0)]
        [TestCase(3, 5)]
        [TestCase(4, 11)]
        public void GetMaxElementOfArray_WhenArray_ShouldReturnMaxElement(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetMaxElementOfArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 0)]
        [TestCase(3, 5)]
        [TestCase(4, -10)]
        public void GetMinElementOfArray_WhenArray_ShouldReturnMinElement(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetMinElementOfArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        public void GetIndexOfMaxElementOfArray_WhenArray_ShouldReturnMaxIndex(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetIndexOfMaxElementOfArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 6)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 2)]
        public void GetIndexOfMinElementOfArray_WhenArray_ShouldReturnMinIndex(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetIndexOfMinElementOfArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 224)]
        [TestCase(2, 0)]
        [TestCase(3, 20)]
        [TestCase(4, 5)]
        public void GetSumOdd_WhenArray_ShouldRetornSumOdd(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetSumOdd(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 5)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 8)]
        public void ReverseArray_WhenArray_ShouldReturnReversedArray(int arrayNumb, int expectedArrayNumb)
        {
            int[] actual = OneDimensionalArrays.ReverseArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(ArrayMock.GetArrayMosk(expectedArrayNumb), actual);
        }


        [TestCase(1, 6)]
        [TestCase(2, 0)]
        [TestCase(3, 8)]
        [TestCase(4, 3)]
        public void GetCountOfOddElements_WhenAray_ShouldReturnCountOfOddElements(int arrayNumb, int expected)
        {
            int actual = OneDimensionalArrays.GetCountOfOddElements(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 11)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 12)]
        public void ChangeHalfsOfArray_WhenArray_ShouldChangeHalfs(int arrayNumb, int expectedArrayNumb)
        {
            int[] actual = OneDimensionalArrays.ChangeHalfsOfArray(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(ArrayMock.GetArrayMosk(expectedArrayNumb), actual);
        }


        [TestCase(1, 6)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 9)]
        public void SortAscending_WhenArray_ShouldBeSortedAscending(int arrayNumb, int expectedArrayNumb)
        {
            int[] actual = OneDimensionalArrays.SortAscending(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(ArrayMock.GetArrayMosk(expectedArrayNumb), actual);
        }

        [TestCase(1, 7)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 10)]
        public void SortDescending_WhenArray_ShouldBeSortedDescending(int arrayNumb, int expectedArrayNumb)
        {
            int[] actual = OneDimensionalArrays.SortDescending(ArrayMock.GetArrayMosk(arrayNumb));
            Assert.AreEqual(ArrayMock.GetArrayMosk(expectedArrayNumb), actual);
        }


    }

    public static class ArrayMock
    {
        public static int[] GetArrayMosk(int arrayNumb)
        {
            int[] array = new int[] { };

            switch (arrayNumb)
            {
                case 1:
                    array = new int[] { 39, 13, 45, 44, 47, 74, 9, 34, 74, 59 };
                    break;

                case 2:
                    array = new int[] { 0, 0, 0, 0, 0, 0 };
                    break;

                case 3:
                    array = new int[] { 5, 5, 5, 5, 5, 5, 5, 5 };
                    break;

                case 4:
                    array = new int[] { -5, -6, -10, 11, 3, 0 };
                    break;

                case 5:
                    array = new int[] { 59, 74, 34, 9, 74, 47, 44, 45, 13, 39 };
                    break;

                case 6:
                    array = array = new int[] { 9, 13, 34, 39, 44, 45, 47, 59, 74, 74 };
                    break;

                case 7:
                    array = array = new int[] { 74, 74, 59, 47, 45, 44, 39, 34, 13, 9 };
                    break;

                case 8:
                    array = new int[] { 0, 3, 11, -10, -6, -5 };
                    break;

                case 9:
                    array = new int[] { -10, -6, -5, 0, 3, 11 };
                    break;

                case 10:
                    array = new int[] { 11, 3, 0, -5, -6, -10 };
                    break; ;

                case 11:
                    array = new int[] { 74, 9, 34, 74, 59, 39, 13, 45, 44, 47 };
                    break; ;

                case 12:
                    array = new int[] { 11, 3, 0, -5, -6, -10 };
                    break;
            }

            return array;
        }
    }
}
