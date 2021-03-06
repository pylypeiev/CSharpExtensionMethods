﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pylypeiev.Extensions
{
    public static class StringSearchingExtensions
    {
        /// <summary>
        /// Determines whether the end of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        public static bool EndsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null) return false;

            return a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether two specified strings have the same value,
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if have same value, otherwise - false</returns>
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines if the string is null or whitespace if yes returns nullAlternateValue, otherwise returns this string
        /// </summary>
        /// <param name="nullAlternateValue">alternative value if the string is null</param>
        /// <returns>the string if its not null or whitespace, otherwise alternative value</returns>
        public static string IfNullThen(this string input, string nullAlternateValue)
        {
            return (!string.IsNullOrWhiteSpace(input)) ? input : nullAlternateValue;
        }

        /// <summary>Determines if this string contains only English letters, upper and lower case</summary>
        /// <returns>true if contains only letters, otherwise - false. If the string is null - false</returns>
        public static bool IsAlpha(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^a-zA-Z]");
        }

        /// <summary>Determines if this string contains only English letters, upper and lower case and digits</summary>
        /// <returns>true if contains only letters and digits, otherwise - false. If the string is null - false</returns>
        public static bool IsAlphaNumeric(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^a-zA-Z0-9]");
        }

        /// <summary>Determines if this string is an anagram</summary>
        /// <returns>true if this string is an anagram, otherwise - false, if one of the strings are null - false</returns>
        public static bool IsAnagram(this string thisString, string otherString)
        {
            if (string.IsNullOrWhiteSpace(thisString) || string.IsNullOrWhiteSpace(otherString)) return false;

            return thisString
                .OrderBy(c => c)
                .SequenceEqual(otherString.OrderBy(c => c));
        }

        /// <summary>Indicates whether this string is null or an empty string</summary>
        /// <returns>true if the string is null or an empty string,otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>Indicates whether this string is null, empty, or consists only of white-space characters</summary>
        /// <returns>true if the string is null or String.Empty, or if value consists exclusively of white-space characters</returns>
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>Determines if this string contains only digits</summary>
        /// <returns>true if contains only digits, otherwise - false. If the string is null - false</returns>
        public static bool IsNumeric(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^0-9]");
        }

        /// <summary>Check if this string is a palindrome</summary>
        /// <returns>true if this string is a palindrome, otherwise - false, If the string is null - false</returns>
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return str.SequenceEqual(str.Reverse());
        }

        /// <summary>Determines if this string is a valid email address</summary>
        /// <returns>true if valid email address, otherwise - false, If the string is null - false</returns>
        public static bool IsValidEmail(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return Regex.IsMatch(str, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
        }

        /// <summary>Determines if this string is a valid IP address</summary>
        /// <returns>true if valid IP address, otherwise - false, If the string is null - false</returns>
        public static bool IsValidIP(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return Regex.IsMatch(str, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }

        /// <summary>
        /// Reports the index of matched string regards to occurrenceNum.
        /// </summary>
        /// <param name="match">string to seek</param>
        /// <param name="occurrenceNum">occurrence number when to return an index</param>
        /// <returns>index, or -1 if not matches</returns>
        public static int NthIndexOf(this string str, string match, int occurrenceNum)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match)) return -1;

            int i = 1;
            int index = 0;

            while (i <= occurrenceNum && (index = str.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurrenceNum) return index;
                i++;
            }
            return -1;
        }

        /// <summary>
        /// Reports the numbers of matches in this string
        /// </summary>
        /// <param name="match"></param>
        /// <returns>the numbers of matches in this string</returns>
        public static int OccurrenceNum(this string str, string match)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match)) return 0;

            return Regex.Matches(str, match).Count;
        }

        /// <summary>
        /// Determines whether the beginning of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        public static bool StartsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null) return false;

            return a.StartsWith(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}