using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class TwoDimensionalArrays
    {

        public static int GetMinElement(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        public static Tuple<int, int> GetIndexOfMinElement(int[,] array)
        {
            int min = GetMinElement(array);
            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] == min)
                    {
                        minI = i;
                        minJ = j;
                        break;
                    }
                }
            }
            return Tuple.Create(minI, minJ);
        }

        public static int GetMaxElement(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        public static Tuple<int, int> GetIndexMaxElement(int[,] array)
        {
            int max = GetMaxElement(array);
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (array[i, j] == max)
                    {
                        maxI = i;
                        maxJ = j;
                        break;
                    }
                }
            }

            return Tuple.Create(maxI, maxJ);
        }

        public static int[,] GetRandomArray(int arrayWidth, int arrayHight, int randomTo)
        {
            int[,] array = new int[arrayHight, arrayWidth];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[i, j] = random.Next(randomTo);
                }
            }
            return array;
        }

        public static void Print(int[,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public static int CountElementsBiggerThanNeighbors(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    if (isHigherThanNeighbours(i, j))
                    {
                        ++count;
                    }
                }
            }
            return count;

            bool isHigherThanNeighbours(int i, int j)
            {
                bool isHigher = true;

                if (i > 0)
                {
                    isHigher = array[i, j] > array[i - 1, j];
                }
                if ((i < array.GetLength(0) - 1) && isHigher)
                {
                    isHigher = array[i, j] > array[i + 1, j];
                }
                if ((j > 0) && isHigher)
                {
                    isHigher = array[i, j] > array[i, j - 1];
                }
                if ((j < array.GetLength(1) - 1) && isHigher)
                {
                    isHigher = array[i, j] > array[i, j + 1];
                }

                return isHigher;
            }
        }

        public static int[,] GetTranspositionArray(int[,] array)
        {
            int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    resultArray[i, j] = array[j, i];
                }
            }
            return resultArray;
        }
    }
}
