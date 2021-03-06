using System;

namespace HomeTaskLibrary
{
    class OneDimensionalArrays
    {
        public static double[] GetRandomArray(int lenght)
        {
            double[] array = new double[lenght];
            int randomTo = 100;
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(randomTo);
            }

            return array;
        }

        public static int GetMaxElementOfArray(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        public static int GetMinElementOfArray(int[] array)
        {
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        public static void Sort(ref int[] array)
        {
            int temp;
            int min;

            for (int i = 0; i < array.Length - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                BranchingStructures.Swap(ref array[min], ref array[i]);                
            }
        }

        public static void print(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
        }
    }
}
