using System;
using System.Text.RegularExpressions;

namespace Pylypeiev.Extensions
{
    public static class StringExtensions
    {
        #region Parsing
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
        #endregion

        #region Searching

        public static int OccurrenceNum(this string text, string search)
        {
            return Regex.Matches(text, search).Count;
        }

        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool StartsWithIgnoreCase(this string a, string b)
        {
            return a.StartsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool EndsWithIgnoreCase(this string a, string b)
        {
            return a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static int NthIndexOf(this string str, string match, int occurrence)
        {
            int i = 1;
            int index = 0;

            while (i <= occurrence && (index = str.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurrence) return index;
                i++;
            }
            return -1;
        }

        public static string IfNullThen(this string input, string nullAlternateValue)
        {
            return (!string.IsNullOrWhiteSpace(input)) ? input : nullAlternateValue;
        }

        #endregion

        #region String Operations

        public static string RemoveLastCharacter(this string instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }
        public static string RemoveLast(this string instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }
        public static string RemoveFirstCharacter(this string instr)
        {
            return instr.Substring(1);
        }
        public static string RemoveFirst(this string instr, int number)
        {
            return instr.Substring(number);
        }

        public static string Reverse(this string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        #endregion
    }
}
