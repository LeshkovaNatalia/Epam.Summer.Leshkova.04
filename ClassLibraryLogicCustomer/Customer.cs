using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLogicCustomer
{
    public class Customer : IFormattable
    {
        #region Properties
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }
        #endregion

        #region Ctors
        public Customer() { }

        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }
        #endregion

        #region Implementation IFormattable

        public override string ToString()
        {
            return String.Format("Customer record: {0}, {1}, {2}", Name, Revenue, ContactPhone);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";

            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                    return String.Format("Customer record: {0}, {1}, {2}", Name, Revenue, ContactPhone);
                case "N":
                    return string.Format("Customer record: {0}", Name);
                case "R":
                    return string.Format("Customer record: {0}", Revenue);
                case "P":
                    return string.Format("Customer record: {0}", ContactPhone);
                case "PN":
                    return string.Format("Customer record: {0}, {1}", ContactPhone, Name);
                case "PR":
                    return string.Format("Customer record: {0}, {1}", ContactPhone, Revenue);
                case "RN":
                    return string.Format("Customer record: {0}, {1}", Revenue, Name);
                case "NR":
                    return string.Format("Customer record: {0}, {1}", Name, Revenue);
                case "NP":
                    return string.Format("Customer record: {0}, {1}", Name, ContactPhone);
                case "RP":
                    return string.Format("Customer record: {0}, {1}", Revenue, ContactPhone);
                case "NRP":
                    return string.Format("Customer record: {0}, {1}, {2}", Name, Revenue, ContactPhone );
                case "NPR":
                    return string.Format("Customer record: {0}, {1}, {2}", Name, Revenue, ContactPhone);
                default:
                    return String.Format("The {0} format string is not supported.", format);
            }
        }
        #endregion
    }
}
