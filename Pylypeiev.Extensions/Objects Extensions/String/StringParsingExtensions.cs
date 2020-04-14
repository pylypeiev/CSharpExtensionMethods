using System;

namespace Pylypeiev.Extensions
{
    public static class StringParsingExtensions
    {
        public static int ToInt(this string input, int defaultValue = 0)
        {
            if (!int.TryParse(input, out int result))
                result = defaultValue;
            return result;
        }

        public static double ToDouble(this string input, double defaultValue = 0)
        {
            if (!double.TryParse(input, out double result))
                result = defaultValue;
            return result;
        }

        public static decimal ToDecimal(this string input, decimal defaultValue = 0)
        {
            if (!decimal.TryParse(input, out decimal result))
                result = defaultValue;
            return result;
        }

        public static long ToLong(this string input, long defaultValue = 0)
        {
            if (!long.TryParse(input, out long result))
                result = defaultValue;
            return result;
        }

        public static DateTime? ToDateTime(this string str)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return null;
        }

        public static DateTime ToDateTime(this string str, DateTime defaultValue)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return defaultValue;
        }
    }
}
