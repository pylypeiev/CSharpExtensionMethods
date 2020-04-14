using System;

namespace Pylypeiev.Extensions
{
    public static class ArrayExtensions
    {
        public static string Join(this Array array, string separator)
        {
            return string.Join(separator, array);
        }

        public static string Join<T>(this T[] array, string separator)
        {
            return string.Join(separator, array);
        }

        public static void ClearAll(this Array arr)
        {
            Array.Clear(arr, 0, arr.Length);
        }

        public static void ClearAll<T>(this T[] arr)
        {
            Array.Clear(arr, 0, arr.Length);
        }

    }
}
