using System;
using System.Diagnostics;
using System.Text;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
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
        [DebuggerStepThrough]
        public static void ClearAll<T>(this T[] arr)
        {
            if (arr != null)
            {
                Array.Clear(arr, 0, arr.Length);
            }
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
        [DebuggerStepThrough]
        public static string Join<T>(this T[] array, string separator)
        {
            if (array == null)
            {
                return string.Empty;
            }

            return string.Join(separator, array);
        }

        /// <summary> Returns a simple string representation of an array.</summary>
        /// <param name="arr">The source array.</param>
        /// <returns>The <see cref="string"/> representation of the array in format [1, 2, 3] and [] if it is null</returns>
        [DebuggerStepThrough]
        public static string ToArrayString<T>(this T[] arr)
        {
            if (arr == null)
            {
                return "[]";
            }

            var sb = new StringBuilder();

            sb.Append('[');

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    sb.Append(",\t");
                }

                sb.Append(arr[i]?.ToString());
            }

            sb.Append(']');

            return sb.ToString();
        }

        /// <summary> Returns a simple string representation of a jagged array.</summary>
        /// <param name="arr">The source array.</param>
        /// <returns>String representation of the array. in format [1, 2, 3] and [] if it is null</returns>
        [DebuggerStepThrough]
        public static string ToArrayString<T>(this T[][] arr)
        {
            if (arr == null)
            {
                return "[]";
            }

            var sb = new StringBuilder();

            sb.Append('[');

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    sb.Append(',');
                    sb.Append(Environment.NewLine);
                    sb.Append(' ');
                }

                sb.Append('[');

                T[] row = arr[i];

                for (int j = 0; j < row.Length; j++)
                {
                    if (j != 0)
                    {
                        sb.Append(",\t");
                    }

                    sb.Append(row[j]?.ToString());
                }

                sb.Append(']');
            }

            sb.Append(']');

            return sb.ToString();
        }

        /// <summary>Returns a simple string representation of a 2D array.</summary>
        /// <param name="arr">The source array.</param>
        /// <returns>The <see cref="string"/> representation of the array in format [[1,2],[3,4]] and [] if it is null</returns>
        [DebuggerStepThrough]
        public static string ToArrayString<T>(this T[,] arr)
        {
            if (arr == null)
            {
                return "[]";
            }

            var sb = new StringBuilder();

            sb.Append('[');

            int
                height = arr.GetLength(0),
                width = arr.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                if (i != 0)
                {
                    sb.Append(',');
                    sb.Append(Environment.NewLine);
                    sb.Append(' ');
                }

                sb.Append('[');

                for (int j = 0; j < width; j++)
                {
                    if (j != 0)
                    {
                        sb.Append(",\t");
                    }

                    sb.Append(arr[i, j]?.ToString());
                }

                sb.Append(']');
            }

            sb.Append(']');

            return sb.ToString();
        }
    }
}