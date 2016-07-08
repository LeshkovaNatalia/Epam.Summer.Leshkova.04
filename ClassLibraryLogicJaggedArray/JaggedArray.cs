using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicJaggedArray
{
    public static class JaggedArray
    {
        #region Method BubbleSortJaggedArray

        /// <summary>
        /// Sorting in increasing(default)/decrasing the SUM of the elements of matrix rows
        /// </summary>
        public static int[][] BubbleSortJaggedArraySum(int[][] array, bool increase = true)
        {
            CheckInputArray(array);

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (increase && (GetSum(array[i]) > GetSum(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }
                    if (!increase && (GetSum(array[i]) < GetSum(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }
                }
            }
            
            return array;
        }

        /// <summary>
        /// Sorting in increasing(default)/decrasing the MAX of elements of matrix rows
        /// </summary>
        public static int[][] BubbleSortJaggedArrayMax(int[][] array, bool increase = true)
        {
            CheckInputArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (increase && (GetMax(array[i]) > GetMax(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }
                    if (!increase && (GetMax(array[i]) < GetMax(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Sorting in increasing(default)/decrasing the MIN of elements of matrix rows
        /// </summary>
        public static int[][] BubbleSortJaggedArrayMin(int[][] array, bool increase = true)
        {
            CheckInputArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (increase && (GetMin(array[i]) > GetMin(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }

                    if (!increase && (GetMin(array[i]) < GetMin(array[j])))
                    {
                        SwapArrays(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        #endregion

        #region Help Method

        /// <summary>
        /// Method CheckInputArray checks was create internal array or not
        /// </summary>
        /// <param name="array">Jagged array</param>
        private static void CheckInputArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Method SwapArrays swaps arrays 
        /// </summary>
        private static void SwapArrays(ref int[] fArray, ref int[] sArray)
        {
            int[] tempArray = fArray;
            fArray = sArray;
            sArray = tempArray;
        }

        /// <summary>
        /// Method GetSum find sum of array elements
        /// </summary>
        /// <param name="array">One-dimensional array</param>
        /// <returns>Sum elements of array of type int</returns>
        private static int GetSum(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
                sum += element;

            return sum;
        }

        /// <summary>
        /// Method GetMax find max element in array
        /// </summary>
        /// <param name="array">One-dimensional array</param>
        /// <returns>Max element in array of type int</returns>
        private static int GetMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if(max < array[i])
                    max = array[i];
            }

            return max;
        }
        /// <summary>
        /// Method GetMin find min element in array
        /// </summary>
        /// <param name="array">One-dimensional array of type int</param>
        /// <returns>Min element in array</returns>
        private static int GetMin(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }

            return min;
        }

        #endregion
    }
}
