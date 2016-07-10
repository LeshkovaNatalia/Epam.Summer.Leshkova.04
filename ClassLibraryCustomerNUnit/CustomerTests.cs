using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicCustomer;
using NUnit.Framework;

namespace ClassLibraryCustomerNUnit
{
    [TestFixture]
    public class CustomerTests
    {
        private static Customer customer = new Customer("Jack", "+37529 4571457", 1000000M);

        private static IEnumerable<TestCaseData> InputValues()
        {
            yield return new TestCaseData("N").Returns(string.Format("Customer record: {0}", customer.Name));
            yield return new TestCaseData("NP").Returns(string.Format("Customer record: {0}, {1}", customer.Name, customer.ContactPhone));
            yield return new TestCaseData("NR").Returns(string.Format("Customer record: {0}, {1}", customer.Name, customer.Revenue));
            yield return new TestCaseData("G").Returns(string.Format("Customer record: {0}, {1}, {2}", customer.Name, customer.Revenue, customer.ContactPhone));
            yield return new TestCaseData("NPP").Returns(string.Format("The NPP format string is not supported."));    
        }

        [Test, TestCaseSource(nameof(InputValues))]
        public string FormattableTest_CustomerToString_ReturnedFormattableString(string format)
        {
            return customer.ToString(format);
        }
    }
}
