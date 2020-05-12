using System;

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
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str.Substring(number);
        }

        /// <summary>Remove the first character of this string </summary>
        /// <returns>substring without first character</returns>
        public static string RemoveFirstCharacter(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str.Substring(1);
        }

        /// <summary>Remove the number of characters at the end of this string</summary>
        /// <param name="number">number of characters to remove</param>
        /// <exception cref="System.ArgumentOutOfRangeException">number is less than zero or greater than the length of this string</exception>
        /// <returns>substring</returns>
        public static string RemoveLast(this string str, int number)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str.Substring(0, str.Length - number);
        }

        /// <summary>Remove the last character of this string</summary>
        /// <returns>substring without last character</returns>
        public static string RemoveLastCharacter(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            return str.Substring(0, str.Length - 1);
        }

        /// <summary>Reverse the sequence of characters in this string</summary>
        /// <returns> reversed string </returns>
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;

            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}