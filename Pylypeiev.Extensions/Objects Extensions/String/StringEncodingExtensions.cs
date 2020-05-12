using System;
using System.Text;

namespace Pylypeiev.Extensions
{
    public static class StringEncodingExtensions
    {
        /// <summary>Decodes a string encoded in base-64</summary>
        /// <returns>Decoded string, if string is empty/whitespace - empty string </returns>
        public static string DecodeBase64(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;

            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        /// <summary>Encodes a string to its equivalent string representation that is encoded in base-64</summary>
        /// <returns> base64 string representation, if string is empty/whitespace - empty string </returns>
        public static string EncodeBase64(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }
    }
}