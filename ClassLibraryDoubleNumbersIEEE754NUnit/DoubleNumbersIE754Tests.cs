using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicNumbersIEEE754;
using NUnit.Framework;

namespace ClassLibraryDoubleNumbersIEEE754NUnit
{
    [TestFixture]
    public class DoubleNumbersIE754Tests
    {
        [TestCase(-312.3125)]
        public void DoubleNumberExtension_DoubleNumber_BinaryFormat(double number)
        {
            string expected = "1100000001110011100001010000000000000000000000000000000000000000";

            string actual = number.BinaryFormatIEEE754();

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestCase(10)]
        public void DoubleNumberExtension_IntNumber_BinaryFormat(double number)
        {
            string expected = "0100000000100100000000000000000000000000000000000000000000000000";

            string actual = number.BinaryFormatIEEE754();

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }


        [TestCase(0.88671875)]
        [ExpectedException(typeof(ArgumentException))]
        public void DoubleNumberExtension2_DoubleNumber_BinaryFormat(double number)
        {
            string actual = number.BinaryFormatIEEE754();
        }

        [TestCase(446.15625)]
        public void DoubleNumberExtension_DoubleNumber15_89_BinaryFormat(double number)
        {
            string expected = "0100000001111011111000101000000000000000000000000000000000000000";

            string actual = number.BinaryFormatIEEE754();

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
