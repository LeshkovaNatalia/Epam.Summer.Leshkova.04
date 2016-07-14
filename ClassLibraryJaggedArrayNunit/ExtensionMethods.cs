using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJaggedArrayNunit
{
    public static class ExtensionMethods
    {
        #region Public Method

        /// <summary>
        /// Method MaxLine find MAX element in array
        /// </summary>
        public static int MaxLine(this int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }

            return max;
        }

        /// <summary>
        /// Method AbsMaxLine find absolute MAX element in array
        /// </summary>
        public static int AbsMaxLine(this int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int max = Math.Abs(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (max < Math.Abs(array[i]))
                    max = Math.Abs(array[i]);
            }

            return max;
        }

        /// <summary>
        /// Method MinLine find MIN element in array
        /// </summary>
        public static int MinLine(this int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }

            return min;
        }

        /// <summary>
        /// Method SumLine find SUM elements in array
        /// </summary>
        public static int SumLine(this int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int sum = 0;

            foreach (int element in array)
                sum += element;

            return sum;
        }

        #endregion
    }
}
