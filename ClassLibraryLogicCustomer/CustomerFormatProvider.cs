using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicCustomer
{
    public class CustomerFormatProvider : IFormatProvider, ICustomFormatter
    {
        #region Implementation IFormatProvider, ICustomFormatter

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "G";

            Customer customer = arg as Customer;

            if (customer == null)
                throw new ArgumentException();

            string custName = customer.Name;
            string custPhone = customer.ContactPhone;
            decimal custRevenue = customer.Revenue;
            
            switch (format)
            {
                case "C":
                    return string.Format("Customer record: {0}, {1:C}, {2}", custName, custRevenue, custPhone);
                case "secure":
                    return string.Format("Customer record: {0}-****", custPhone.ToString().Remove(10));
                default:
                    return customer.ToString();
            }
        }

        #endregion
    }
}
