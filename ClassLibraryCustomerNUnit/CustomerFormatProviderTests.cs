using System;
using System.Collections.Generic;
using ClassLibraryLogicCustomer;
using NUnit.Core;
using NUnit.Framework;
using ClassLibraryCustomerNUnit;

namespace ClassLibraryCustomerNUnit
{
    [TestFixture()]
    public class CustomerFormatProviderTests
    {
        private static Customer customer = new Customer("Jack", "+37529-457-1457", 1000000M);

        private static IEnumerable<TestCaseData> InputValues()
        {
            yield return new TestCaseData("{0:secure}").Returns(string.Format("Customer record: +37529-457-****"));
            yield return new TestCaseData("{0:C}").Returns(string.Format("Customer record: {0}, 1 000 000,00р., {1}", customer.Name, customer.ContactPhone));
            yield return new TestCaseData("{0:P}").Returns(string.Format("Customer record: {0}, {1}, {2}", customer.Name, customer.Revenue, customer.ContactPhone));
            yield return new TestCaseData("{0:G}").Returns(string.Format("Customer record: {0}, {1}, {2}", customer.Name, customer.Revenue, customer.ContactPhone));
        }

        [Test, TestCaseSource(nameof(InputValues))]
        public string CustomFormatterTest_UseFormatCustomer_ReturnedFormatedCustomer(string format)
        {
            return string.Format(new CustomerFormatProvider(), format, customer);
        }

    }
}