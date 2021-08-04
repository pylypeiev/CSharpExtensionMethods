using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace Pylypeiev.Extensions
{
    public static class StringOperationsExtensions
    {
        /// <summary>Remove the number of characters at the start of this string</summary>
        /// <param name="number">number of characters to remove</param>
        /// <exception cref="System.ArgumentOutOfRangeException">number is less than zero or greater than the length of this string</exception>
        /// <returns>substring</returns>
        public static string RemoveFirst(this string str, int number)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return str.Substring(number);
        }

        /// <summary>Remove the first character of this string </summary>
        /// <returns>substring without first character</returns>
        public static string RemoveFirstCharacter(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return str.Substring(1);
        }

        /// <summary>Remove the number of characters at the end of this string</summary>
        /// <param name="number">number of characters to remove</param>
        /// <exception cref="System.ArgumentOutOfRangeException">number is less than zero or greater than the length of this string</exception>
        /// <returns>substring</returns>
        public static string RemoveLast(this string str, int number)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return str.Substring(0, str.Length - number);
        }

        /// <summary>Remove the last character of this string</summary>
        /// <returns>substring without last character</returns>
        public static string RemoveLastCharacter(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return str.Substring(0, str.Length - 1);
        }

        /// <summary>Reverse the sequence of characters in this string</summary>
        /// <returns> reversed string </returns>
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        /// <summary>Split CamelCase words</summary>
        /// <param name="matchTimeout">optional parameter for REGEX match timeout, if not provided 1 second is set </param>
        /// <returns>split words</returns>
        /// <exception cref="RegexMatchTimeoutException">
        /// The exception that is thrown when the execution time of a regular expression pattern-matching method exceeds its time-out interval.
        /// </exception>
        public static string SplitCamelCase(this string str, TimeSpan? matchTimeout = null)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return Regex.Replace(str,
                                 "([A-Z])",
                                 " $1",
                                 RegexOptions.Compiled,
                                 matchTimeout ?? TimeSpan.FromSeconds(1))
                        .Trim();
        }

        /// <summary>
        /// Surround this string with some string
        /// </summary>
        public static string SurroundWith(this string str, string surrounder)
        {
            return surrounder + str + surrounder;
        }

        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase).
        /// </summary>
        /// <returns>The specified string converted to title case.</returns>
        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            return cultureInfo.TextInfo.ToTitleCase(str.ToLower());
        }

        /// <summary>Performs a trim only if the item is not null</summary>
        /// <returns>The string that remains after all white-space characters are removed from the
        ///     start and end of the current string. If no characters can be trimmed from the
        ///     current instance, the method returns the current instance unchanged. If string is null - string.Empty returned
        ///</returns>
        public static string TrimSafe(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Trim();
        }
        /// <summary>Performs ToLower() only if input is not null</summary>
        /// <returns>The lowercase equivalent of the current string or string.Empty if input is null</returns>
        public static string ToLowerSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToLower();
        }

        /// <summary>Performs ToLower() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to lowercase, using the casing rules
        //     of the specified culture  or string.Empty if input is null</returns>
        public static string ToLowerSafe(this string input, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToLower(culture);
        }

        /// <summary>Performs ToLowerInvariant() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to lowercase, using the casing rules
        //     of the invariant culture or string.Empty if input is null</returns>
        public static string ToLowerInvariantSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToLowerInvariant();
        }

        /// <summary>Performs ToUpper() only if input is not null</summary>
        /// <returns>The uppercase equivalent of the current string  or string.Empty if input is null</returns>
        public static string ToUpperSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToUpper();
        }

        /// <summary>Performs ToUpper() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to uppercase, using the casing rules
        //     of the specified culture. or string.Empty if input is null</returns>
        public static string ToUpperSafe(this string input, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToUpper(culture);
        }

        /// <summary>Performs ToUpperInvariant() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to uppercase, using the casing rules
        //     of the invariant culture or string.Empty if input is null</returns>
        public static string ToUpperInvariantSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.ToUpperInvariant();
        }
    }
}