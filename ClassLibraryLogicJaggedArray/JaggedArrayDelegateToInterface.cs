using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicJaggedArray
{

    public static class JaggedArrayDelegateToInterface
    {
        #region Public Methods

        /// <summary>
        /// Sorting elements of matrix rows according to comparator
        /// </summary>
        public static void SortJaggedArray(int[][] array, IComparer<int[]> comparer)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

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
        }

        /// <summary>
        /// Sorting elements of matrix rows according to comparator.
        /// </summary>
        public static void SortArray(int[][] array, Comparison<int[]> comparer)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));
            
            SortJaggedArray(array, new CompareAdapter(comparer));
        }

        #endregion

        #region Private Class Methods

        /// <summary>
        /// Class CompareAdapter is Adapter between delegate and interface
        /// </summary>
        private class CompareAdapter : IComparer<int[]>
        {
            #region Field
            private readonly Comparison<int[]> _comparison;
            #endregion

            #region Ctor
            public CompareAdapter(Comparison<int[]> comparison)
            {
                _comparison = comparison;
            }
            #endregion

            #region Public Method
            /// <summary>
            /// Method Compare compare two array
            /// </summary>
            /// <param name="x">First array</param>
            /// <param name="y">Second array</param>
            public int Compare(int[] x, int[] y)
            {
                return _comparison(x, y);
            }
            #endregion
        }

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
