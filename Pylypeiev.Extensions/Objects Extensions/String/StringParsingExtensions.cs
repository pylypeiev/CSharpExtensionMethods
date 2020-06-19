using System;
using System.Text;

namespace Pylypeiev.Extensions
{
    public static class StringParsingExtensions
    {
        /// <summary>Convert to DateTime</summary>
        /// <returns>DateTime if converting succeeded, otherwise - null</returns>
        public static DateTime? ToDateTime(this string str)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return null;
        }

        /// <summary>Convert to DateTime</summary>
        /// <param name="defaultValue">DateTime that will be returned if converting will not succeed</param>
        /// <returns>DateTime if converting succeeded, otherwise - defaultValue</returns>
        public static DateTime ToDateTime(this string str, DateTime defaultValue)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return defaultValue;
        }

        /// <summary>Convert to decimal</summary>
        /// <param name="defaultValue"></param>
        /// <returns>decimal if converting succeeded, otherwise - defaultValue</returns>
        public static decimal ToDecimal(this string input, decimal defaultValue = 0)
        {
            if (!decimal.TryParse(input, out decimal result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to double</summary>
        /// <param name="defaultValue"></param>
        /// <returns>double if converting succeeded, otherwise - defaultValue</returns>
        public static double ToDouble(this string input, double defaultValue = 0)
        {
            if (!double.TryParse(input, out double result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to float</summary>
        /// <param name="defaultValue"></param>
        /// <returns>float if converting succeeded, otherwise - defaultValue</returns>
        public static float ToFloat(this string input, float defaultValue = 0)
        {
            if (!float.TryParse(input, out float result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to int</summary>
        /// <param name="defaultValue"></param>
        /// <returns>int if converting succeeded, otherwise - defaultValue</returns>
        public static int ToInt(this string input, int defaultValue = 0)
        {
            if (!int.TryParse(input, out int result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to long</summary>
        /// <param name="defaultValue"></param>
        /// <returns>long if converting succeeded, otherwise - defaultValue</returns>
        public static long ToLong(this string input, long defaultValue = 0)
        {
            if (!long.TryParse(input, out long result))
                result = defaultValue;
            return result;
        }

        /// <summary>Converts a string into an byte array.</summary>
        /// <param name="str">A string to convert.</param>
        /// <param name="encoding">An encoding for conversion. Default is UTF8.</param>
        /// <returns>A byte array. If string is null or empty - empty byte array.</returns>
        public static byte[] ToByteArray(this string str, Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(str)) return new byte[0];

            if (encoding == null)
                encoding = Encoding.UTF8;

            return encoding.GetBytes(str);
        }
    }
}