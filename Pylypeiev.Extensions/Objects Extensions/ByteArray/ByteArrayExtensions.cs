using System;

namespace Pylypeiev.Extensions
{
    public static class ByteArrayExtensions
    {
        public static string ToBase64String(this byte[] arr)
        {
            return Convert.ToBase64String(arr);
        }
    }
}
