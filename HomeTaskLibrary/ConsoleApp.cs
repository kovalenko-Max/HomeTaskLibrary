using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTaskLibrary
{
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            //int[] array = OneDimensionalArrays.GetRandomArray(6);
            //OneDimensionalArrays.Print(array);

            //int minValue = OneDimensionalArrays.GetMinElementOfArray(array);
            //int minIndex = OneDimensionalArrays.GetIndexOfMinElementOfArray(array);

            //int maxValue = OneDimensionalArrays.GetMaxElementOfArray(array);
            //int maxIndex = OneDimensionalArrays.GetIndexOfMaxElementOfArray(array);

            //Console.WriteLine($"MinValue = {minValue}[{minIndex}] \nMaxValue = {maxValue}[{maxIndex}]");

            int n = 10;

            Console.WriteLine(Cycles.GetFibNumb(n));
=======
            int[,] array = TwoDimensionalArrays.GetRandomArray(6, 3, 100);
            TwoDimensionalArrays.Print(array);

            int minVal = TwoDimensionalArrays.GetMinElement(array);
            Tuple<int, int> indexOfMinValue = TwoDimensionalArrays.GetIndexOfMinElement(array);
            int maxVal = TwoDimensionalArrays.GetMaxElement(array);
            Tuple<int, int> indexOfMaxValue = TwoDimensionalArrays.GetIndexMaxElement(array);   
                        
            Console.WriteLine("Max Value = " + maxVal + " " + indexOfMaxValue + "\nMin Value = " + minVal + " " + indexOfMinValue);

            Console.WriteLine("Count = " + TwoDimensionalArrays.CountElementsBiggerThanNeighbors(array));

            int[,] tArray = TwoDimensionalArrays.GetTranspositionArray(array);

            TwoDimensionalArrays.Print(tArray);

>>>>>>> master
        }
    }
}
