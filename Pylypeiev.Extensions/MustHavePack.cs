#if DEBUG

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

<<<<<<< HEAD
namespace Pylypeiev.Extensions.MustHavePack
{
    public static class ExtensionMethods
=======
namespace Pylypeiev.Extensions.MustHave
{
    public static class MinimalPack
>>>>>>> c8c957026b9548d6a671b1a9ae25bafd8f244641
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


        /// <summary> Add an element with provided key to dictionary if this key is not exist yet </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="value"> The object to use as a value </param>
        /// <exception cref="System.ArgumentNullException">key is null</exception>
        /// <returns> True if added to dictionary, otherwise, false. </returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
                return true;
            }

            return false;
        }

        /// <summary> Add an element with provided key to dictionary, if this key is exist - update value </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="value"> The object to use as a value </param>
        /// <exception cref="System.ArgumentNullException">key is null</exception>
        /// <exception cref="System.NotSupportedException">dictionary is read only</exception>
        /// <returns> Element on dictionary on provided key. </returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
            else
            {
                dict[key] = value;
            }

            return dict[key];
        }

        /// <summary>Add an element to the end of the collection if this value is not exist yet</summary>
        /// <param name="value"> The object to add</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        /// <returns> True if added to collection, otherwise, false. </returns>
        public static bool AddIfNotContains<T>(this ICollection<T> collection, T value)
        {
            if (!collection.Contains(value))
            {
                collection.Add(value);
                return true;
            }
            return false;
        }

        /// <summary> Adds the elements of the specified Array to the end of the collection </summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        public static void AddRange<T>(this ICollection<T> collection, params T[] values)
        {
            foreach (T value in values)
                collection.Add(value);
        }

        /// <summary>Adds the elements of the specified IEnumerable to the end of the collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable values)
        {
            foreach (T value in values)
                collection.Add(value);
        }


        /// <summary>Removes a range of elements from collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        public static void RemoveRange<T>(this ICollection<T> collection, params T[] values)
        {
            foreach (T value in values)
                collection.Remove(value);
        }

        /// <summary>Removes a range of elements from collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        public static void RemoveRange<T>(this ICollection<T> collection, IEnumerable values)
        {
            foreach (T value in values)
                collection.Remove(value);
        }

        /// <summary> Add the object top the end of IEnumerable </summary>
        /// <param name="element">object to append</param>
        /// <returns>updated IEnumerable</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
        {
            foreach (var item in source)
                yield return item;
            yield return element;
        }

<<<<<<< HEAD
=======
        /// <summary> Check if all elements in IEnumerable are equals </summary>
        /// <returns>true if they are equals, otherwise - false</returns>
        public static bool AreAllSame<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            using (var enumerator = enumerable.GetEnumerator())
            {
                var toCompare = default(T);
                if (enumerator.MoveNext())
                    toCompare = enumerator.Current;

                while (enumerator.MoveNext())
                    if (toCompare != null && !toCompare.Equals(enumerator.Current))
                        return false;
            }

            return true;
        }
>>>>>>> c8c957026b9548d6a671b1a9ae25bafd8f244641

        /// <summary>
        /// Concatenates the elements of an IEnumerable<string> to 1 string. Uses StringBuilder
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns>concatenated string</returns>
        public static string Concatenate(this IEnumerable<string> enumerable)
        {
            var sb = new StringBuilder();

            foreach (var s in enumerable)
                sb.Append(s);

            return sb.ToString();
        }

        /// <summary>
        /// Performs the specified action on each element of the IEnumerable
        /// <strong>Use only if you must</strong>
        /// </summary>
        /// <param name="action">action to perform</param>
        /// <exception cref="System.ArgumentNullException">action is null</exception>
        /// <exception cref="System.InvalidOperationException">An element in the collection has been modified</exception>
        /// <returns>this IEnuerable</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
                action(item);

            return collection;
        }

        /// <summary> Check if IEnumerable is empty </summary>
        /// <exception cref="System.ArgumentNullException">IEnumerable is null</exception>
        /// <returns>true if collection is empty, otherwise - false</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        /// <summary> Check if IEnumerable is <strong>NOT</strong> empty </summary>
        /// <exception cref="System.ArgumentNullException">IEnumerable is null</exception>
        /// <returns>true if collection is not empty, otherwise - false</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Any();
        }

        /// <summary> Check if IEnumerable is null or empty </summary>
        /// <returns>true if IEnumerable is null or empty, otherwise - false</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable?.Any() != true;
        }

        /// <summary>
        /// Concatenates the elements of an IEnumerable, using the specified separator between each element
        /// </summary>
        /// <param name="separator">
        /// The string to use as a separator. separator is included in the returned string
        /// only if values has more than one element/
        /// </param>
        /// <exception cref="System.ArgumentNullException">if values is null</exception>
        /// <returns>
        /// A string that consists of the elements of values delimited by the separator string.
        /// If values is an empty IEnumerable, the method returns String.Empty.
        /// </returns>
        public static string Join<T>(this IEnumerable<T> self, string separator)
        {
            return string.Join(separator, self.Select(e => e.ToString()).ToArray());
        }

        /// <summary> Add the object at the beginning of IEnumerable </summary>
        /// <param name="element">object to prepend</param>
        /// <returns>updated IEnumerable</returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element)
        {
            yield return element;
            foreach (var item in source)
                yield return item;
        }

        /// <summary> Chunk a list to smaller lists with a maximum capacity of the chunk size</summary>
        /// <param name="chunkSize"> a maximum capacity of the chunk size</param>
        /// <returns>List with chunked lists</returns>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        /// <summary>Clone an collection to new IList</summary>
        /// <returns>cloned new IList</returns>
        public static IList<T> Clone<T>(this IList<T> list) where T : ICloneable
        {
            var cloned = new List<T>(list.Count);
            foreach (var item in list)
                cloned.Add((T)item.Clone());

            return cloned;
        }

        /// <summary> Adds an object to the collection and return this collection for fluent api</summary>
        /// <param name="item"> The object to add</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        /// <returns>this collection</returns>
        public static TList Push<TList, TItem>(this TList list, TItem item) where TList : IList<TItem>
        {
            list.Add(item);
            return list;
        }


        /// <summary>
        /// Get time from this DateTime in numbers format.
        /// </summary>
        /// <param name="timeFormat">string format applied on DateTime, please provide only time-specified formats</param>
        /// <returns></returns>
        public static int GetTime(this DateTime date, string timeFormat = "HHmmss")
        {
            return date.ToString(timeFormat).ToInt();
        }


        /// <summary>Returns the absolute value of this number.</summary>
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        /// <summary>Returns the smallest integral value that is greater than or equal to the specified number</summary>
        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }

        /// <summary>Returns the largest integral value that is greater than or equal to the specified number</summary>
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static decimal GetPercentage(this decimal value, decimal percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this decimal number, decimal a, decimal b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static decimal Max(this decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static decimal Min(this decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///  Rounds a decimal value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <exception cref="System.OverflowException">The result is outside the range</exception>
        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        /// <summary>
        ///  Rounds a decimal value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <exception cref="System.OverflowException">The result is outside the range</exception>
        public static decimal Round(this decimal d, int decimals)
        {
            return Math.Round(d, decimals);
        }

        /// <summary>Returns the absolute value of this number.</summary>
        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }

        /// <summary>Returns the smallest integral value that is greater than or equal to the specified number</summary>
        public static double Ceiling(this double value)
        {
            return Math.Ceiling(value);
        }

        /// <summary>Returns the largest integral value that is greater than or equal to the specified number</summary>
        public static double Floor(this double value)
        {
            return Math.Floor(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static double GetPercentage(this double value, double percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this double number, double a, double b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static double Max(this double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///  Rounds a double value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        /// <summary>
        ///  Rounds a double value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <param name="doubles">The number of fractional digits in the return value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">doubles is less than 0 or greater than 15</exception>
        public static double Round(this double d, Int32 doubles)
        {
            return Math.Round(d, doubles);
        }

        /// <summary>Returns the absolute value of this number.</summary>
        public static float Abs(this float value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static float GetPercentage(this float value, float percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this float number, float a, float b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static float Max(this float val1, float val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static float Min(this float val1, float val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static double GetPercentage(this int value, int percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this int number, int a, int b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static int Max(this int val1, int val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static int Min(this int val1, int val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static double GetPercentage(this long value, long percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this long number, long a, long b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static long Max(this long val1, long val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static long Min(this long val1, long val2)
        {
            return Math.Min(val1, val2);
        }


        /// <summary>Perform action on the object if it not null</summary>
        /// <param name="action">action to perform</param>
        public static void IfNotNull<T>(this T obj, Action<T> action) where T : class
        {
            if (obj != null)
                action(obj);
        }

        /// <summary>Perform function on the object if it not null</summary>
        /// <param name="func">function to perform</param>
        /// <returns>return function result or default value of the object if it is null</returns>
        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func) where T : class
        {
            return obj != null ? func(obj) : default;
        }

        /// <summary>Perform function on the object if it not null, otherwise return default value</summary>
        /// <param name="func">function to perform</param>
        /// <param name="defaultValue">default value if object is null</param>
        /// <returns>return function result or default value of the object if it is null</returns>
        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            return obj != null ? func(obj) : defaultValue;
        }

        /// <summary>Check if object equals to its a default value</summary>
        /// <param name="source"></param>
        /// <returns>True is object equals to its a default value, otherwise false</returns>
        public static bool IsDefaultValue<T>(this T source)
        {
            return source.Equals(default(T));
        }

        /// <summary>Determines if an object is contained in a sequence</summary>
        /// <param name="sequence"></param>
        /// <exception cref="System.ArgumentNullException">object is null</exception>
        /// <returns>true if object is contained in sequence, otherwise - false</returns>
        public static bool IsIn<T>(this T obj, params T[] sequence)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            return sequence.Contains(obj);
        }

        /// <summary>Check if object is NOT null</summary>
        /// <returns>true if object is not null, otherwise - false</returns>
        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        /// <summary>Check if object is null</summary>
        /// <returns>true if object is null, otherwise - false</returns>
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        /// <summary>like ToString of the object, but not crushes if the object is null</summary>
        /// <returns>ToString of the object, if the object is null - empty string</returns>
        public static string ToStringSafe(this object str)
        {
            return str == null ? "" : str.ToString();
        }

        /// <summary>
        /// try to perform a function on the object, if not succeed return default value of the object
        /// </summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <returns>result of the function or a default value if not succeed </returns>
        public static TResult Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction)
        {
            try
            {
                return tryFunction(obj);
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// try to perform a function on the object, if not succeed return catchValue
        /// </summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="catchValue">value to return if not succeed</param>
        /// <returns>result of the function or a catchValue if not succeed </returns>
        public static TResult Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, TResult catchValue)
        {
            try
            {
                return tryFunction(obj);
            }
            catch
            {
                return catchValue;
            }
        }

        /// <summary>try to perform a function on the object and return an object with out parameter</summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="result">result of try function</param>
        /// <returns>return true if the function succeeded and result accordingly, otherwise - false and default value of result</returns>
        public static bool Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, out TResult result)
        {
            try
            {
                result = tryFunction(obj);
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        /// <summary>try to perform a function on the object and return an object with out parameter</summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="catchValue">value to return if not succeed</param>
        /// <param name="result">result of try function</param>
        /// <returns>return true if the function succeeded and result accordingly, otherwise - false and catchValue</returns>
        public static bool Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, TResult catchValue, out TResult result)
        {
            try
            {
                result = tryFunction(obj);
                return true;
            }
            catch
            {
                result = catchValue;
                return false;
            }
        }

        /// <summary>try to perform an action on the object</summary>
        /// <param name="tryAction">action to try to perform</param>
        /// <returns>true if the action succeeded, otherwise - false</returns>
        public static bool Try<TType>(this TType obj, Action<TType> tryAction)
        {
            try
            {
                tryAction(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>try to perform an action on the object, if not succeeded - perform another action</summary>
        /// <param name="tryAction">action to try to perform</param>
        /// <param name="catchAction">action to perform if first action not succeeded </param>
        /// <returns>true if first action succeeded, otherwise - false</returns>
        public static bool Try<TType>(this TType obj, Action<TType> tryAction, Action<TType> catchAction)
        {
            try
            {
                tryAction(obj);
                return true;
            }
            catch
            {
                catchAction(obj);
                return false;
            }
        }

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

        /// <summary>Convert to DateTime</summary>
        /// <returns>DateTime if converting succeeded, otherwise - null</returns>
        public static DateTime? ToDateTime(this string str)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return null;
        }

        /// <summary>Convert to DateTime</summary>
        /// <param name="defaultValue">DateTime that will be returned if converting will not succeed</param>
        /// <returns>DateTime if converting succeeded, otherwise - defaultValue</returns>
        public static DateTime ToDateTime(this string str, DateTime defaultValue)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return defaultValue;
        }

        /// <summary>Convert to decimal</summary>
        /// <param name="defaultValue"></param>
        /// <returns>decimal if converting succeeded, otherwise - defaultValue</returns>
        public static decimal ToDecimal(this string input, decimal defaultValue = 0)
        {
            if (!decimal.TryParse(input, out decimal result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to double</summary>
        /// <param name="defaultValue"></param>
        /// <returns>double if converting succeeded, otherwise - defaultValue</returns>
        public static double ToDouble(this string input, double defaultValue = 0)
        {
            if (!double.TryParse(input, out double result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to float</summary>
        /// <param name="defaultValue"></param>
        /// <returns>float if converting succeeded, otherwise - defaultValue</returns>
        public static float ToFloat(this string input, float defaultValue = 0)
        {
            if (!float.TryParse(input, out float result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to int</summary>
        /// <param name="defaultValue"></param>
        /// <returns>int if converting succeeded, otherwise - defaultValue</returns>
        public static int ToInt(this string input, int defaultValue = 0)
        {
            if (!int.TryParse(input, out int result))
                result = defaultValue;
            return result;
        }

        /// <summary>Convert to long</summary>
        /// <param name="defaultValue"></param>
        /// <returns>long if converting succeeded, otherwise - defaultValue</returns>
        public static long ToLong(this string input, long defaultValue = 0)
        {
            if (!long.TryParse(input, out long result))
                result = defaultValue;
            return result;
        }

        /// <summary>
        /// Determines whether the end of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        public static bool EndsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null) return false;

            return a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether two specified strings have the same value,
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if have same value, otherwise - false</returns>
        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines if the string is null or whitespace if yes returns nullAlternateValue, otherwise returns this string
        /// </summary>
        /// <param name="nullAlternateValue">alternative value if the string is null</param>
        /// <returns>the string if its not null or whitespace, otherwise alternative value</returns>
        public static string IfNullThen(this string input, string nullAlternateValue)
        {
            return (!string.IsNullOrWhiteSpace(input)) ? input : nullAlternateValue;
        }

<<<<<<< HEAD
=======
        /// <summary>Determines if this string contains only English letters, upper and lower case</summary>
        /// <returns>true if contains only letters, otherwise - false. If the string is null - false</returns>
        public static bool IsAlpha(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^a-zA-Z]");
        }

        /// <summary>Determines if this string contains only English letters, upper and lower case and digits</summary>
        /// <returns>true if contains only letters and digits, otherwise - false. If the string is null - false</returns>
        public static bool IsAlphaNumeric(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^a-zA-Z0-9]");
        }
>>>>>>> c8c957026b9548d6a671b1a9ae25bafd8f244641

        /// <summary>Indicates whether this string is null or an empty string</summary>
        /// <returns>true if the string is null or an empty string,otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>Indicates whether this string is null, empty, or consists only of white-space characters</summary>
        /// <returns>true if the string is null or String.Empty, or if value consists exclusively of white-space characters</returns>
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>Determines if this string contains only digits</summary>
        /// <returns>true if contains only digits, otherwise - false. If the string is null - false</returns>
        public static bool IsNumeric(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            return !Regex.IsMatch(str, "[^0-9]");
        }


        /// <summary>
        /// Reports the index of matched string regards to occurrenceNum.
        /// </summary>
        /// <param name="match">string to seek</param>
        /// <param name="occurrenceNum">occurrence number when to return an index</param>
        /// <returns>index, or -1 if not matches</returns>
        public static int NthIndexOf(this string str, string match, int occurrenceNum)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match)) return -1;

            int i = 1;
            int index = 0;

            while (i <= occurrenceNum && (index = str.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurrenceNum) return index;
                i++;
            }
            return -1;
        }

        /// <summary>
        /// Reports the numbers of matches in this string
        /// </summary>
        /// <param name="match"></param>
        /// <returns>the numbers of matches in this string</returns>
        public static int OccurrenceNum(this string str, string match)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(match)) return 0;

            return Regex.Matches(str, match).Count;
        }

        /// <summary>
        /// Determines whether the beginning of this string matches the specified string
        /// compared using OrdinalIgnoreCase.
        /// </summary>
        /// <param name="b">The string to compare to</param>
        /// <returns>true if matches, otherwise - false, if some of the strings are null - false</returns>
        public static bool StartsWithIgnoreCase(this string a, string b)
        {
            if (a == null || b == null) return false;

            return a.StartsWith(b, StringComparison.OrdinalIgnoreCase);
        }


        /// <summary>Wraps this object instance into an IEnumerable, consisting of a single item.</summary>
        /// <param name="item"> The instance that will be wrapped.</param>
        /// <returns> An IEnumerable of a single item. </returns>
        public static IEnumerable<T> Yield<T>(this T item)
        {
            yield return item;
        }

        /// <summary>
        /// Determines whether two specified chars have the same value
        /// </summary>
        /// <param name="compareTo">The char to compare to</param>
        /// <returns>true if have same value, otherwise - false</returns>
        public static bool EqualsIgnoreCase(this char ch, char compareTo)
        {
            return char.ToUpperInvariant(ch) == char.ToUpperInvariant(compareTo);
        }


        /// <summary> Shuffle IEnumerable </summary>
        /// <returns> a random shuffled IEnumerable</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(_ => Guid.NewGuid());
        }

        /// <summary>Pick a random element from IEnumerable</summary>
        /// <returns> 1 random element of type T </returns>
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        /// <summary>Pick N random elements from IEnumerable</summary>
        /// <param name="count">number of objects of type T to pick</param>
        /// <returns> IEnumerable collecting N random element of type T </returns>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        /// <summary>
<<<<<<< HEAD
=======
        /// Get all permutations for this List. Please use only if you need this, memory and GC is under your responsibility!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<List<T>> GetPermutations<T>(this List<T> list)
        {
            var result = new List<List<T>>();
            if (list.Count == 1)
            {
                result.Add(list);
                return result;
            }
            foreach (var element in list)
            {
                var remainingList = new List<T>(list);
                remainingList.Remove(element);
                foreach (var permutation in GetPermutations(remainingList))
                {
                    permutation.Add(element);
                    result.Add(permutation);
                }
            }
            return result;
        }

        /// <summary>
>>>>>>> c8c957026b9548d6a671b1a9ae25bafd8f244641
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
            var cultureInfo = Thread.CurrentThread.CurrentCulture;
            return cultureInfo.TextInfo.ToTitleCase(str.ToLower());
        }

        /// <summary>
        /// Get the innermost exception from this exception
        /// </summary>
        /// <returns>innermost exception</returns>
        public static Exception GetInnermostException(this Exception ex)
        {
            var innerMostException = ex;
            while (innerMostException.InnerException != null)
                innerMostException = innerMostException.InnerException;

            return innerMostException;
        }

        /// <summary>Add a number to this number </summary>
        public static decimal Plus(this decimal value, decimal value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static decimal Minus(this decimal value, decimal value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static decimal DivideBy(this decimal value, decimal value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static decimal MultiplyBy(this decimal value, decimal value2)
        {
            return value / value2;
        }

        /// <summary>Add a number to this number </summary>
        public static double Plus(this double value, double value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static double Minus(this double value, double value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static double DivideBy(this double value, double value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static double MultiplyBy(this double value, double value2)
        {
            return value / value2;
        }

        /// <summary>Add a number to this number </summary>
        public static float Plus(this float value, float value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static float Minus(this float value, float value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static float DivideBy(this float value, float value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static float MultiplyBy(this float value, float value2)
        {
            return value / value2;
        }

        /// <summary>Add a number to this number </summary>
        public static int Plus(this int value, int value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static int Minus(this int value, int value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static int DivideBy(this int value, int value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static int MultiplyBy(this int value, int value2)
        {
            return value / value2;
        }

        /// <summary>Add a number to this number </summary>
        public static long Plus(this long value, long value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static long Minus(this long value, long value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static long DivideBy(this long value, long value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static long MultiplyBy(this long value, long value2)
        {
            return value / value2;
        }

        /// <summary>
        /// Check if this DateTime is default, empty value
        /// </summary>
        /// <returns>true if </returns>
        public static bool IsDefault(this DateTime target)
        {
            return target == default;
        }

        /// <summary>
        /// Get list of inner exceptions from this exception
        /// </summary>
        /// <returns>IEnumerable of inner exceptions from this exceptions</returns>
        public static IEnumerable<Exception> GetInnerExceptions(this Exception ex)
        {
            var innerEx = ex.InnerException;
            while (innerEx != null)
            {
                yield return innerEx;
                innerEx = innerEx.InnerException;
            }
        }

        /// <summary> Get an element with provided key if this key is exist, otherwise default value </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="defaultValue"> TValue that will be returned if key is not exist</param>
        /// <returns>  Get an element with provided key if this key is exist, otherwise default value </returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
        {
            if (dict.TryGetValue(key, out TValue value)) return value;

            return defaultValue;
        }

        /// <summary>Safe foreach and more, returns an empty Enumerable if source is null. </summary>
        /// <returns> Source if not null, otherwise Enumerable.Empty </returns>
        public static IEnumerable<T> ThisOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable ?? Enumerable.Empty<T>();
        }

        /// <summary>Safe foreach and more, returns an empty Enumerable if source is null. </summary>
        /// <returns> Source if not null, otherwise Enumerable.Empty </returns>
        public static IEnumerable ThisOrEmpty(this IEnumerable enumerable)
        {
            return enumerable ?? new ArrayList(0);
        }

<<<<<<< HEAD

=======
>>>>>>> c8c957026b9548d6a671b1a9ae25bafd8f244641
        /// <summary>Performs a trim only if the item is not null</summary>
        /// <returns>The string that remains after all white-space characters are removed from the
        ///     start and end of the current string. If no characters can be trimmed from the
        ///     current instance, the method returns the current instance unchanged. If string is null - string.Empty returned
        ///</returns>
        public static string TrimSafe(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;

            return str.Trim();
        }

        /// <summary>Performs ToLower() only if input is not null</summary>
        /// <returns>The lowercase equivalent of the current string or string.Empty if input is null</returns>
        public static string ToLowerSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToLower();
        }

        /// <summary>Performs ToLower() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to lowercase, using the casing rules
        //     of the specified culture  or string.Empty if input is null</returns>
        public static string ToLowerSafe(this string input, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToLower(culture);
        }

        /// <summary>Performs ToLowerInvariant() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to lowercase, using the casing rules
        //     of the invariant culture or string.Empty if input is null</returns>
        public static string ToLowerInvariantSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToLowerInvariant();
        }


        /// <summary>Performs ToUpper() only if input is not null</summary>
        /// <returns>The uppercase equivalent of the current string  or string.Empty if input is null</returns>
        public static string ToUpperSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToUpper();
        }

        /// <summary>Performs ToUpper() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to uppercase, using the casing rules
        //     of the specified culture. or string.Empty if input is null</returns>
        public static string ToUpperSafe(this string input, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToUpper(culture);
        }

        /// <summary>Performs ToUpperInvariant() only if input is not null</summary>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>  Returns a copy of this string converted to uppercase, using the casing rules
        //     of the invariant culture or string.Empty if input is null</returns>
        public static string ToUpperInvariantSafe(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return input.ToUpperInvariant();
        }

        /// <summary> Returns a simple string representation of an array.</summary>
        /// <param name="arr">The source array.</param>
        /// <returns>The <see cref="string"/> representation of the array in format [1, 2, 3] and [] if it is null</returns>
        public static string ToArrayString<T>(this T[] arr)
        {
            if (arr == null) return "[]";

            var sb = new StringBuilder();

            sb.Append('[');

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0) sb.Append(",\t");

                sb.Append(arr[i]?.ToString());
            }

            sb.Append(']');

            return sb.ToString();
        }

        /// <summary> Returns a simple string representation of a jagged array.</summary>
        /// <param name="arr">The source array.</param>
        /// <returns>String representation of the array. in format [1, 2, 3] and [] if it is null</returns>
        public static string ToArrayString<T>(this T[][] arr)
        {
            if (arr == null) return "[]";

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
                    if (j != 0) sb.Append(",\t");

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
        public static string ToArrayString<T>(this T[,] arr)
        {
            if (arr == null) return "[]";

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
                    if (j != 0) sb.Append(",\t");

                    sb.Append(arr[i, j]?.ToString());
                }

                sb.Append(']');
            }

            sb.Append(']');

            return sb.ToString();
        }
    }
}

#endif