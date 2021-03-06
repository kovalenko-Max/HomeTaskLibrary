using System;

namespace HomeTaskLibrary
{
    public class OneDimensionalArrays
    {
        public static int[] GetRandomArray(int lenght)
        {
            int[] array = new int[lenght];
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

        public static int GetIndexOfMaxElementOfArray(int[] array)
        {
            int maxValue = GetMaxElementOfArray(array);
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == maxValue)
                {
                    maxIndex = i;
                    break;
                }                
            }
            return maxIndex;
        }

        public static int GetIndexOfMinElementOfArray(int[] array)
        {
            int minValue = GetMinElementOfArray(array);
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == minValue)
                {
                    minIndex = i;
                    break;
                }
            }
            return minIndex;
        }

        public static int GetSumOdd(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return 0;
        }
        
        public static void ReverseArray(ref int[] array)
        {
            int halfLenght = array.Length / 2;

            for (int i = 0; i < halfLenght; ++i)
            {
                int rotateIndex = array.Length - 1 - i;
                Variables.Swap(ref array[i], ref array[rotateIndex]);
            }            
        }

        public static int GetCountOfOddElements(int[] array)
        {
            int count = 0;            
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 != 0)
                {
                    ++count;
                }
            }
            return count;
        }

        public static void ChangeHalfsOfArray(ref int[] array)
        {
            int halfLenght = array.Length / 2;
            int j = array.Length % 2 == 0 ? halfLenght : halfLenght + 1;

            for (int i = 0; i < halfLenght; ++i)
            {
                Variables.Swap(ref array[i], ref array[j]);
                ++j;
            }
        }

        public static void SortAscending(ref int[] array)
        {            
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
                Variables.Swap(ref array[min], ref array[i]);
            }
        }

        public static void SortDescending(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                while ((j >= 0) && (array[j] < array[j + 1]))
                {
                    Variables.Swap(ref array[j], ref array[j + 1]);
                    j--;
                }
            }
        }

        public static void Print(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
