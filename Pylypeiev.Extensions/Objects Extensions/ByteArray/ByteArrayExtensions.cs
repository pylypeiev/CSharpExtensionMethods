using System;

namespace Pylypeiev.Extensions
{
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// Converts an byte array to its equivalent string representation that is encoded with base-64.
        /// </summary>
        /// <returns> base64 string representation, if array is empty - returns empty string </returns>
        public static string ToBase64String(this byte[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return string.Empty;
            }

            return Convert.ToBase64String(arr);
        }
    }
}