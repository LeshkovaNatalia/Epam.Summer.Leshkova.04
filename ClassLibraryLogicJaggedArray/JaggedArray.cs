using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicJaggedArray
{
    
    public static class JaggedArray
    {

        #region Public Methods

        /// <summary>
        /// Sorting elements of matrix rows according to comparator
        /// </summary>
        public static int[][] SortJaggedArray(int[][] array, ICustomComparer comparer)
        {
            CheckInputArray(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
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

        /// <summary>
        /// Method CheckInputArray checks was create internal array or not
        /// </summary>
        /// <param name="array">Jagged Array</param>
        private static void CheckInputArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    throw new ArgumentException();
            }
        }

        #endregion
    }
}
