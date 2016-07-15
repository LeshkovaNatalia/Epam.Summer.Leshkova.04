using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicJaggedArray;
using NUnit.Framework;

namespace ClassLibraryJaggedArrayNunit
{
    [TestFixture]
    public class JaggedArrayTests
    {
        private static readonly int[][] InputArray = {new int[] {8, 5, 4}, new int[] {1, 16, 3, 5}, new int[] {5, 7}};
    
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArrayTest_SortArrayException_ReturnedException()
        {
            int[][] array = new int[3][];
            JaggedArrayInterfaceToDelegate.SortJaggedArray(array, new ComparerAbsMaxLine());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArrayTest_SortArrayNullComparer_ReturnedException()
        {
            JaggedArrayDelegateToInterface.SortArray(InputArray, null);
        }

        [Test]
        public void JaggedArrayTest_SortArraySumLineElement_ReturnedSortArray()
        {
            int[][] array = new int[3][];
            InputArray.CopyTo(array, 0);

            int[][] expected =
            {
                new int[] { 5, 7 },
                new int[] { 8, 5, 4 },
                new int[] { 1, 16, 3, 5 }
            };
            
            JaggedArrayInterfaceToDelegate.SortJaggedArray(array, new ComparerSumLine());

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void JaggedArrayTest_SortArraySumLineElements_ReturnedSortArray()
        {
            int[][] array = new int[3][];
            InputArray.CopyTo(array, 0);

            int[][] expected =
            {
                new int[] { 5, 7 },
                new int[] { 8, 5, 4 },
                new int[] { 1, 16, 3, 5 }
            };

            JaggedArrayDelegateToInterface.SortArray(array, new ComparerSumLine().Compare);

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void JaggedArrayTest_SortArrayMinLineElements_ReturnedSortArray()
        {
            int[][] array = new int[3][];
            InputArray.CopyTo(array, 0);

            int[][] expected =
            {
                new int[] { 1, 16, 3, 5 },
                new int[] { 8, 5, 4 },
                new int[] { 5, 7 }
            };

            JaggedArrayDelegateToInterface.SortArray(array, (a, b) => a.MinLine().CompareTo(b.MinLine()));

            CollectionAssert.AreEqual(expected, array);
        }

        [Test]
        public void JaggedArrayTest_SortArrayMaxEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[] { -8, 5, 4 },
                new int[] { 1, 6, 3, 5 },
                new int[] { 5, -7 }
            };

            int[][] expected =
            {
                new int[] { 1, 6, 3, 5 },
                new int[] { 5, -7 },
                new int[] { -8, 5, 4 }
            };

            JaggedArrayInterfaceToDelegate.SortJaggedArray(array, new ComparerAbsMaxLine());

            CollectionAssert.AreEqual(expected, array);
        }
    }
}