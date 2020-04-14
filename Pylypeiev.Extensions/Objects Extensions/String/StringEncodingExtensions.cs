using System;
using System.Text;

namespace Pylypeiev.Extensions
{
    public static class StringEncodingExtensions
    {
        public static string DecodeBase64(this string str)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(str));
        }

        public static string EncodeBase64(this string str)
        {
            return Convert.ToBase64String(new ASCIIEncoding().GetBytes(str));
        }
    }
}
