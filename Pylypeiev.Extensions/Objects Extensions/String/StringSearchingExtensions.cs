using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pylypeiev.Extensions
{
    public static class StringSearchingExtensions
    {
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

        public static bool IsAlphaNumeric(this string str)
        {
            return !Regex.IsMatch(str, "[^a-zA-Z0-9]");
        }
        public static bool IsAlpha(this string str)
        {
            return !Regex.IsMatch(str, "[^a-zA-Z]");
        }

        public static bool IsNumeric(this string str)
        {
            return !Regex.IsMatch(str, "[^0-9]");
        }

        public static bool IsAnagram(this string thisString, string otherString)
        {
            return thisString
                .OrderBy(c => c)
                .SequenceEqual(otherString.OrderBy(c => c));
        }

        public static bool IsPalindrome(this string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static bool IsValidEmail(this string str)
        {
            return Regex.IsMatch(str, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
        }

        public static bool IsValidIP(this string str)
        {
            return Regex.IsMatch(str, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }
    }
}
