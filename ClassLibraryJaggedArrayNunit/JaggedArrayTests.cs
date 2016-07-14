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
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JaggedArrayTest_SortArrayException_ReturnedException()
        {
            int[][] array = new int[3][];
            JaggedArrayInterfaceToDelegate.SortJaggedArray(array, new ComparerAbsMaxLine());
        }

        [Test]
        public void JaggedArrayTest_SortArraySumLineElement_ReturnedSortArray()
        {
            int[][] array =
            {
                 new int[] { 8, 5, 4 },
                 new int[] { 1, 16, 3, 5 },
                 new int[] { 5, 7 }
            };

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
            int[][] array =
            {
                new int[] { 8, 5, 4 },
                new int[] { 1, 16, 3, 5 },
                new int[] { 5, 7 }
            };

            int[][] expected =
            {
                new int[] { 5, 7 },
                new int[] { 8, 5, 4 },
                new int[] { 1, 16, 3, 5 }
            };

            ComparerSumLine sumLineComparer = new ComparerSumLine();
            JaggedArrayDelegateToInterface.SortArray(array, sumLineComparer.Compare);

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