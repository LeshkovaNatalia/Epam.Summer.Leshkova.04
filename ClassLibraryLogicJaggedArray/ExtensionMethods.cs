using System;

namespace ClassLibraryLogicJaggedArray
{
    public static class ExtensionMethods
    {
        #region Public Method

        /// <summary>
        /// Method MaxLine find MAX element in array
        /// </summary>
        public static int MaxLine(this int[] array)
        {
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
            int sum = 0;

            foreach (int element in array)
                sum += element;

            return sum;
        }

        #endregion
    }
}
