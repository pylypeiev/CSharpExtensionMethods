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
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        /// <summary>Encodes a string to its equivalent string representation that is encoded in base-64</summary>
        /// <returns> base64 string representation, if string is empty/whitespace - empty string </returns>
        public static string EncodeBase64(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        /// <summary>Computes MD5 hash of a string.</summary>
        /// <param name="str">String to hash.</param>
        /// <param name="encoding">An encoding for conversion. Default is UTF8.</param>
        /// <returns>MD5 hash in hexadecimal format. If string is null or empty - empty string</returns>
        public static string ToMd5(this string str, Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            var stringBuilder = new StringBuilder(32);
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                foreach (byte num in md5.ComputeHash(encoding.GetBytes(str)))
                {
                    stringBuilder.Append(num.ToString("x2"));
                }
            }
            return stringBuilder.ToString();
        }
    }
}