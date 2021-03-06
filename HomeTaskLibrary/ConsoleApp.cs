using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
            int[] array = OneDimensionalArrays.GetRandomArray(6);
            OneDimensionalArrays.Print(array);

            int minValue = OneDimensionalArrays.GetMinElementOfArray(array);
            int minIndex = OneDimensionalArrays.GetIndexOfMinElementOfArray(array);

            int maxValue = OneDimensionalArrays.GetMaxElementOfArray(array);
            int maxIndex = OneDimensionalArrays.GetIndexOfMaxElementOfArray(array);

            Console.WriteLine($"MinValue = {minValue}[{minIndex}] \nMaxValue = {maxValue}[{maxIndex}]");
        }
    }
}
