using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicJaggedArray
{
    public static class JaggedArrayInterfaceToDelegate
    {
        #region Public Methods

        /// <summary>
        /// Delegate MethodSort use as comparator for sort
        /// </summary>
        /// <param name="fArray">First array for compare</param>
        /// <param name="sArray">Second array for compare</param>
        /// <returns>Returns result of comparing two arrays</returns>
        public delegate int MethodSort(int[] fArray, int[] sArray);

        /// <summary>
        /// Sorting elements of matrix rows according to comparator
        /// </summary>
        public static void SortJaggedArray(int[][] array, ICustomComparer comparer)
        {
            SortArray(array, (MethodSort)comparer.Compare);
        }

        /// <summary>
        /// Sorting elements of matrix rows according to comparator
        /// </summary>
        public static void SortArray(int[][] array, MethodSort comparer)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) > 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Method Swap swaps arrays 
        /// </summary>
        private static void Swap(ref int[] fArray, ref int[] sArray)
        {
            int[] tempArray = fArray;
            fArray = sArray;
            sArray = tempArray;
        }

        #endregion
    }
}
