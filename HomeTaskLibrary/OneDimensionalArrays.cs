using System;

namespace HomeTaskLibrary
{
    class OneDimensionalArrays
    {
        public static void Sort(ref double[] array)
        {
            double temp;
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
    }
}
