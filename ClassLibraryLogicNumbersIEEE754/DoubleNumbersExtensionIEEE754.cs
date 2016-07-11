using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryLogicNumbersIEEE754
{
    public static class DoubleNumbersExtensionIEEE754
    {
        #region Method BinaryFormatIEEE754
        /// <summary>
        /// Extension method to double. It represents a double-precision number in binary form 
        /// in accordance format IEEE754
        /// </summary>
        public static string BinaryFormatIEEE754(this double number)
        {
            int numOfBits = 64;
            BitArray resultBitArray = new BitArray(numOfBits);

            int sign = ((int)number >> 63) & 1;
            resultBitArray[63] = (sign == 1);

            int integerPart = (int)Math.Truncate(number);
            double fractionalPart = number - integerPart;
            int posMantissa = 51;
            int order = 0;

            if (integerPart != 0)
                GetBinaryIntegralPart(integerPart, resultBitArray, ref posMantissa, ref order);
            else
                throw new ArgumentException();

            if(fractionalPart != 0)
                GetBinaryFractionalPart(fractionalPart, resultBitArray, posMantissa + 1);
            
            GetBinaryOrder(order, resultBitArray);
            
            return BitToString(resultBitArray);
        }

        #endregion

        #region Help Private Method

        /// <summary>
        /// Method GetBinaryIntegralPart return integral part in binary format
        /// </summary>
        private static void GetBinaryIntegralPart(int integralPart, BitArray bitArray, ref int posMantissa, ref int order)
        {
            string result = string.Empty;

            if (integralPart < 0)
                integralPart = integralPart * (-1);

            while (integralPart > 0)
            {
                result += integralPart%2;
                integralPart /= 2;
            }

            posMantissa -= result.Length;
            order = 51 - posMantissa - 1;

            char[] charArr = result.Remove(result.Length - 1).ToCharArray();
            
            SetCharToBitArray(bitArray, charArr, 51);
        }

        /// <summary>
        /// Method GetBinaryFractionalPart get fractional part in binary mode
        /// </summary>
        private static void GetBinaryFractionalPart(double fractionalPart, BitArray bitArray, int posMantissa)
        {
            if (fractionalPart < 0)
                fractionalPart *= -1;

            int count = -1;
            double getNum = fractionalPart;
            
            while (getNum % 10 != 0)
            {
                getNum *= 10;
                count++;
            }
            
            for (int i = 0; i < count; i++)
            {
                if (fractionalPart > 1)
                    fractionalPart -= 1;
                fractionalPart *= 2;
                bitArray[posMantissa] = ((int)Math.Truncate(fractionalPart) == 1);
                posMantissa--;
            }
        }

        /// <summary>
        /// Method GetBinaryOrder get order in binary mode
        /// </summary>
        private static void GetBinaryOrder(int count, BitArray bitArray)
        {
            string result = string.Empty;

            int order = count + 1023;

            while (order > 0)
            {
                result += order % 2;
                order /= 2;
            }

            SetCharToBitArray(bitArray, result.ToCharArray(), bitArray.Length-2);
        }

        /// <summary>
        /// Method BitToString convert BitArray to String in reverse mode
        /// </summary>
        private static string BitToString(BitArray bitArray)
        {
            var result = new StringBuilder();

            for (int i = bitArray.Count - 1; i >= 0; i--)
            {
                char c = bitArray[i] ? '1' : '0';
                result.Append(c);
            }

            return result.ToString();
        }

        /// <summary>
        /// Set char array to BitArray in special order
        /// </summary>
        private static void SetCharToBitArray(BitArray bitArray, char[] res, int to)
        {
            for (int i = to, j = res.Length - 1; j >= 0; i--, j--)
            {
                bitArray[i] = (res[j] == '1');
            }
        }

        #endregion
    }
}
