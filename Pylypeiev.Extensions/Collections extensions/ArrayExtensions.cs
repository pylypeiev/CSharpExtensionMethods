using System;

namespace Pylypeiev.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Sets a range of elements in an array to the default value of each element type.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">if array is null</exception>
        /// <exception cref="System.IndexOutOfRangeException">
        /// index is less than the lower bound of array. -or- length is less than zero. -or-
        /// The sum of index and length is greater than the size of array.
        /// </exception>
        public static void ClearAll(this Array arr)
        {
            Array.Clear(arr, 0, arr.Length);
        }

        /// <summary>
        /// Sets a range of elements in an array to the default value of each element type.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">if array is null</exception>
        /// <exception cref="System.IndexOutOfRangeException">
        /// index is less than the lower bound of array. -or- length is less than zero. -or-
        /// The sum of index and length is greater than the size of array.
        /// </exception>
        public static void ClearAll<T>(this T[] arr)
        {
            Array.Clear(arr, 0, arr.Length);
        }

        /// <summary>
        /// Concatenates the elements of an object array, using the specified separator between each element
        /// </summary>
        /// <param name="separator">
        /// The string to use as a separator. separator is included in the returned string
        /// only if values has more than one element/
        /// </param>
        /// <exception cref="System.ArgumentNullException">if values is null</exception>
        /// <returns>
        /// A string that consists of the elements of values delimited by the separator string.
        /// If values is an empty array, the method returns System.String.Empty.
        /// </returns>
        public static string Join(this Array array, string separator)
        {
            return string.Join(separator, array);
        }

        /// <summary>
        /// Concatenates the elements of an object array, using the specified separator between each element
        /// </summary>
        /// <param name="separator">
        /// The string to use as a separator. separator is included in the returned string
        /// only if values has more than one element/
        /// </param>
        /// <exception cref="System.ArgumentNullException">if values is null</exception>
        /// <returns>
        /// A string that consists of the elements of values delimited by the separator string.
        /// If values is an empty array, the method returns System.String.Empty.
        /// </returns>
        public static string Join<T>(this T[] array, string separator)
        {
            return string.Join(separator, array);
        }
    }
}