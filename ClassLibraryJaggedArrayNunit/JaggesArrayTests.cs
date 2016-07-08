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
    public class JaggesArrayTests
    {
        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void JaggedArrayMethodTest_SortArraySumEl_ReturnedException()
        {
            int[][] array = new int[3][];
            JaggedArray.BubbleSortJaggedArraySum(array, true);
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void JaggedArrayMethodTest_SortArrayMaxEl_ReturnedException()
        {
            int[][] array = new int[5][];
            JaggedArray.BubbleSortJaggedArrayMax(array, true);
        }

        [Test]
        [ExpectedException(typeof(NullReferenceException))]
        public void JaggedArrayMethodTest_SortArrayMinEl_ReturnedException()
        {
            int[][] array = new int[13][];
            JaggedArray.BubbleSortJaggedArrayMin(array, true);
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayIncreaseSumEl_ReturnedSortArray()
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
            
            int[][] actual = JaggedArray.BubbleSortJaggedArraySum(array, true);

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayDecreaseSumEl_ReturnedSortArray()
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

            int[][] actual = JaggedArray.BubbleSortJaggedArraySum(array, false);

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayIncreaseMaxEl_ReturnedSortArray()
        {
            int[][] array =
            {
                new int[3] { 8, 5, 4 },
                new int[4] { 1, 16, 3, 5 },
                new int[2] { 5, 7 }
            };

            int[][] expected =
            {
                new int[2] { 5, 7 },
                new int[3] { 8, 5, 4 },
                new int[4] { 1, 16, 3, 5 }
            };

            int[][] actual = JaggedArray.BubbleSortJaggedArrayMax(array);

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayDecreaseMaxEl_ReturnedSortArray()
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

            int[][] actual = JaggedArray.BubbleSortJaggedArrayMax(array, false);

            Assert.That(expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayIncreaseMinEl_ReturnedSortArray()
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
            
            int[][] actual = JaggedArray.BubbleSortJaggedArrayMin(array);

            Assert.That(expected[0], Is.EqualTo(actual[0]), "{0} != {1}", expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]), "{0} != {1}", expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]), "{0} != {1}", expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortArrayDecreaseMinEl_ReturnedSortArray()
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

            int[][] actual = JaggedArray.BubbleSortJaggedArrayMin(array, false);

            Assert.That(expected[0], Is.EqualTo(actual[0]), "{0} != {1}", expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]), "{0} != {1}", expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]), "{0} != {1}", expected[2], Is.EqualTo(actual[2]));
        }

        [Test]
        public void JaggedArrayMethodTest_SortNegativeArrayDecreaseMinEl_ReturnedSortArray()
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

            int[][] actual = JaggedArray.BubbleSortJaggedArrayMin(array, true);

            Assert.That(expected[0], Is.EqualTo(actual[0]), "{0} != {1}", expected[0], Is.EqualTo(actual[0]));
            Assert.That(expected[1], Is.EqualTo(actual[1]), "{0} != {1}", expected[1], Is.EqualTo(actual[1]));
            Assert.That(expected[2], Is.EqualTo(actual[2]), "{0} != {1}", expected[2], Is.EqualTo(actual[2]));
        }
    }
}
