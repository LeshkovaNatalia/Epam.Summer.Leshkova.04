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
        [ExpectedException(typeof(ArgumentException))]
        public void JaggedArrayTest_SortArrayMaxEl_ReturnedException()
        {
            int[][] array = new int[3][];
            JaggedArray.SortJaggedArray(array, new CompareAbsMaxLine());
        }

        [Test]
        public void JaggedArrayTest_SortArraySumEl_ReturnedSortArray()
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
            
            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareSumLine());

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayTest_SortArrayDecreaseSumEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[] { 8, 5, 4 },
                new int[] { 1, 16, 3, 5 },
                new int[] { 5, 7 }
            };

            int[][] expected =
            {
                new int[] { 1, 16, 3, 5 },
                new int[] { 8, 5, 4 },
                new int[] { 5, 7 }
            };

            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareSumLineDesc());

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
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
                new int[3] { -8, 5, 4 },
                new int[2] { 5, -7 },
                new int[4] { 1, 6, 3, 5 }
            };

            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareAbsMaxLineDesc());

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayTest_SortArrayDecreaseMaxEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[3] { 8, 5, 4 },
                new int[4] { 1, 16, 3, 5 },
                new int[2] { 5, 7 }
            };

            int[][] expected =
            {
                new int[4] { 1, 16, 3, 5 },
                new int[3] { 8, 5, 4 },
                new int[2] { 5, 7 }
            };

            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareAbsMaxLineDesc());

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayTest_SortArrayMinEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[] { 8, 5, 4 },
                new int[] { 1, 6, 3, 5 },
                new int[] { 5, 7 }
            };

            int[][] expected =
            {
                new int[4] { 1, 6, 3, 5 },
                new int[3] { 8, 5, 4 },
                new int[2] { 5, 7 }
            };

            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareMinLine());

            Assert.That(expected[0], Is.EqualTo(actual[0]), "{0} != {1}", expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]), "{0} != {1}", expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]), "{0} != {1}", expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayTest_SortArrayDecreaseMinEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[] { 8, 5, 4 },
                new int[] { 1, 6, 3, 5 },
                new int[] { 5, 7 }
            };

            int[][] expected =
            {
                new int[2] { 5, 7 },
                new int[3] { 8, 5, 4 },
                new int[4] { 1, 6, 3, 5 }
            };

            int[][] actual = JaggedArray.SortJaggedArray(array, new CompareMinLineDesc());

            Assert.That(expected[0], Is.EqualTo(actual[0]), "{0} != {1}", expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]), "{0} != {1}", expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]), "{0} != {1}", expected[2], Is.EqualTo(actual[2]));
        }
    }
}