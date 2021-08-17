using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class StringSearchingExtensions
    {
        /// <summary>
        /// Determines whether the end of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        [DebuggerStepThrough]
        public static bool EndsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            return a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether two specified strings have the same value,
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if have same value, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines if the string is null or whitespace if yes returns nullAlternateValue, otherwise returns this string
        /// </summary>
        /// <param name="nullAlternateValue">alternative value if the string is null</param>
        /// <returns>the string if its not null or whitespace, otherwise alternative value</returns>
        [DebuggerStepThrough]
        public static string IfNullThen(this string input, string nullAlternateValue)
        {
            return (!string.IsNullOrWhiteSpace(input)) ? input : nullAlternateValue;
        }

        /// <summary>Determines if this string contains only English letters, upper and lower case</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>true if contains only letters, otherwise - false. If the string is null - false</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static bool IsAlpha(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return !Regex.IsMatch(str,
                                  "[^a-zA-Z]",
                                  RegexOptions.Compiled,
                                  matchTimeout ?? TimeSpan.FromSeconds(1));
        }

        /// <summary>Determines if this string contains only English letters, upper and lower case and digits</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>true if contains only letters and digits, otherwise - false. If the string is null - false</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static bool IsAlphaNumeric(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return !Regex.IsMatch(str,
                                  "[^a-zA-Z0-9]",
                                  RegexOptions.Compiled,
                                  matchTimeout ?? TimeSpan.FromSeconds(1));
        }

        /// <summary>Indicates whether this string is null or an empty string</summary>
        /// <returns>true if the string is null or an empty string,otherwise, false.</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>Indicates whether this string is null, empty, or consists only of white-space characters</summary>
        /// <returns>true if the string is null or String.Empty, or if value consists exclusively of white-space characters</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>Determines if this string contains only digits</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>true if contains only digits, otherwise - false. If the string is null - false</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static bool IsNumeric(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return !Regex.IsMatch(str,
                                 "[^0-9]",
                                 RegexOptions.Compiled,
                                 matchTimeout ?? TimeSpan.FromSeconds(1));
        }

        /// <summary>Check if this string is a palindrome</summary>
        /// <returns>true if this string is a palindrome, otherwise - false, If the string is null - false</returns>
        [DebuggerStepThrough]
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return str.SequenceEqual(str.Reverse());
        }

        /// <summary>Determines if this string is a valid email address</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>true if valid email address, otherwise - false, If the string is null - false</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static bool IsValidEmail(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return Regex.IsMatch(str,
                                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$",
                                RegexOptions.Compiled,
                                matchTimeout ?? TimeSpan.FromSeconds(1));
        }

        /// <summary>Determines if this string is a valid IP address</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>true if valid IP address, otherwise - false, If the string is null - false</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static bool IsValidIP(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            return Regex.IsMatch(str,
                                @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$",
                                RegexOptions.Compiled,
                                matchTimeout ?? TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Reports the index of matched string regards to occurrenceNum.
        /// </summary>
        /// <param name="match">string to seek</param>
        /// <param name="occurrenceNum">occurrence number when to return an index</param>
        /// <returns>index, or -1 if not matches</returns>
        [DebuggerStepThrough]
        public static int NthIndexOf(this string str, string match, int occurrenceNum)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match))
            {
                return -1;
            }

            int i = 1;
            int index = 0;

            while (i <= occurrenceNum && (index = str.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurrenceNum)
                {
                    return index;
                }

                i++;
            }
            return -1;
        }

        /// <summary>Reports the numbers of matches in this string</summary>
        /// <param name="match"></param>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>the numbers of matches in this string</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        [DebuggerStepThrough]
        public static int OccurrenceNum(this string str, string match, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match))
            {
                return 0;
            }

            return Regex.Matches(str,
                                 match,
                                 RegexOptions.Compiled,
                                 matchTimeout ?? TimeSpan.FromSeconds(1))
                        .Count;
        }

        /// <summary>
        /// Determines whether the beginning of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        [DebuggerStepThrough]
        public static bool StartsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            return a.StartsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Returns a value indicating whether a specified substring occurs within this string.</summary>
        /// <param name="value"> The string to seek</param>
        /// <param name="stringComparison">One of the enumeration values that determines how this string and value are compared.</param>
        /// <returns>true if the value parameter occurs within this string, otherwise - false.</returns>
        [DebuggerStepThrough]
        public static bool ContainsInvariantSafe(this string str, string value, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
        {
            if (str == null || value == null)
            {
                return false;
            }

            return str.IndexOf(value, stringComparison) >= 0;
        }
    }
}