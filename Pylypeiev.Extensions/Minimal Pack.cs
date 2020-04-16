
#if DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Pylypeiev.Extensions.Minimal
{
    public static class MinimalPack
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

        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
                return true;
            }

            return false;
        }

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

        public static bool IsNullOrEmpty(this ICollection obj)
        {
            return obj == null || obj.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }

        public static void AddRange<T>(this ICollection<T> collection, params T[] values)
        {
            foreach (T value in values)
                collection.Add(value);
        }

        public static bool AddIfNotContains<T>(this ICollection<T> collection, T value)
        {
            if (!collection.Contains(value))
            {
                collection.Add(value);
                return true;
            }
            return false;
        }

        public static void RemoveRange<T>(this ICollection<T> collection, params T[] values)
        {
            foreach (T value in values)
                collection.Remove(value);
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
                action(item);

            return collection;
        }

        public static string Join<T>(this IEnumerable<T> self, string separator)
        {
            return string.Join(separator, self.Select(e => e.ToString()).ToArray());
        }

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

        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
        {
            foreach (var item in source)
                yield return item;
            yield return element;
        }

        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element)
        {
            yield return element;
            foreach (var item in source)
                yield return item;
        }

        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable?.Any() != true;
        }

        public static string Concatenate(this IEnumerable<string> enumerable)
        {
            var sb = new StringBuilder();

            foreach (var s in enumerable)
                sb.Append(s);

            return sb.ToString();
        }

        public static IList<T> Clone<T>(this IList<T> list) where T : ICloneable
        {
            var cloned = new List<T>(list.Count);
            foreach (var item in list)
                cloned.Add((T)item.Clone());

            return cloned;
        }

        public static TList Push<TList, TItem>(this TList list, TItem item) where TList : IList<TItem>
        {
            list.Add(item);
            return list;
        }

        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        public static string ToBase64String(this byte[] arr)
        {
            return Convert.ToBase64String(arr);
        }

        public static int GetTime(this DateTime date, string timeFormat = "HHmmss")
        {
            return date.ToString(timeFormat).ToInt();
        }

        public static bool IsBetween(this decimal number, decimal a, decimal b)
        {
            return a <= number && number <= b;
        }
        public static decimal GetPercentage(this decimal value, decimal percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }

        public static decimal Max(this decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }

        public static decimal Min(this decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }

        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        public static decimal Round(this decimal d, Int32 decimals)
        {
            return Math.Round(d, decimals);
        }

        public static bool IsBetween(this double number, double a, double b)
        {
            return a <= number && number <= b;
        }

        public static double GetPercentage(this double value, double percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }

        public static double Ceiling(this double value)
        {
            return Math.Ceiling(value);
        }
        public static double Floor(this double value)
        {
            return Math.Floor(value);
        }

        public static double Max(this double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        public static double Round(this double d, Int32 doubles)
        {
            return Math.Round(d, doubles);
        }

        public static bool IsBetween(this float number, float a, float b)
        {
            return a <= number && number <= b;
        }

        public static float GetPercentage(this float value, float percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static float Abs(this float value)
        {
            return Math.Abs(value);
        }

        public static float Max(this float val1, float val2)
        {
            return Math.Max(val1, val2);
        }

        public static float Min(this float val1, float val2)
        {
            return Math.Min(val1, val2);
        }

        public static bool IsBetween(this int number, int a, int b)
        {
            return a <= number && number <= b;
        }

        public static int Max(this int val1, int val2)
        {
            return Math.Max(val1, val2);
        }

        public static int Min(this int val1, int val2)
        {
            return Math.Min(val1, val2);
        }

        public static bool IsBetween(this long number, long a, long b)
        {
            return a <= number && number <= b;
        }

        public static long Max(this long val1, long val2)
        {
            return Math.Max(val1, val2);
        }

        public static long Min(this long val1, long val2)
        {
            return Math.Min(val1, val2);
        }

        public static double GetPercentage(this long value, long percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        public static double GetPercentage(this int value, int percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        public static Dictionary<string, string> GetPropertiesWithValues(this object obj)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            Type objectType = obj.GetType();

            foreach (PropertyInfo prop in new List<PropertyInfo>(objectType.GetProperties()))
            {
                object propValue = prop.GetValue(obj, null);
                dictionary.Add(prop.Name, propValue?.ToString());
            }

            return dictionary;
        }

        public static string GetPropertiesWithValues(this object obj, string propNameValueSeparator = " = ", string propsSeparator = ", ")
        {
            var sb = new StringBuilder();

            var objectType = obj.GetType();
            foreach (PropertyInfo prop in new List<PropertyInfo>(objectType.GetProperties()))
            {
                object propValue = prop.GetValue(obj, null);
                sb.Append(prop.Name).Append(propNameValueSeparator).Append(propValue?.ToString()).Append(propsSeparator);
            }

            return sb.ToString();
        }

        public static bool IsIn<T>(this T source, params T[] list)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return list.Contains(source);
        }

        public static bool IsDefault<T>(this T source)
        {
            return source.Equals(default(T));
        }

        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        public static void IfNotNull<T>(this T obj, Action<T> action) where T : class
        {
            if (obj != null)
                action(obj);
        }

        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func) where T : class
        {
            return obj != null ? func(obj) : default;
        }

        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            return obj != null ? func(obj) : defaultValue;
        }

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

        public static string ToStringSafe(this object str)
        {
            return str == null ? "" : str.ToString();
        }

        public static string DecodeBase64(this string str)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(str));
        }

        public static string EncodeBase64(this string str)
        {
            return Convert.ToBase64String(new ASCIIEncoding().GetBytes(str));
        }

        public static void SaveAs(this string str, string fileName, bool append = false)
        {
            using (var tw = new StreamWriter(fileName, append))
            {
                tw.Write(str);
            }
        }

        public static void SaveAs(this string str, FileInfo file, bool append = false)
        {
            using (var tw = new StreamWriter(file.FullName, append))
            {
                tw.Write(str);
            }
        }

        public static string RemoveLastCharacter(this string instr)
        {
            return instr.Substring(0, instr.Length - 1);
        }
        public static string RemoveLast(this string instr, int number)
        {
            return instr.Substring(0, instr.Length - number);
        }
        public static string RemoveFirstCharacter(this string instr)
        {
            return instr.Substring(1);
        }
        public static string RemoveFirst(this string instr, int number)
        {
            return instr.Substring(number);
        }

        public static string Reverse(this string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static int ToInt(this string input, int defaultValue = 0)
        {
            if (!int.TryParse(input, out int result))
                result = defaultValue;
            return result;
        }

        public static double ToDouble(this string input, double defaultValue = 0)
        {
            if (!double.TryParse(input, out double result))
                result = defaultValue;
            return result;
        }

        public static decimal ToDecimal(this string input, decimal defaultValue = 0)
        {
            if (!decimal.TryParse(input, out decimal result))
                result = defaultValue;
            return result;
        }

        public static long ToLong(this string input, long defaultValue = 0)
        {
            if (!long.TryParse(input, out long result))
                result = defaultValue;
            return result;
        }

        public static DateTime? ToDateTime(this string str)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return null;
        }

        public static DateTime ToDateTime(this string str, DateTime defaultValue)
        {
            if (DateTime.TryParse(str, out DateTime date))
                return date;

            return defaultValue;
        }

        public static int OccurrenceNum(this string text, string search)
        {
            return Regex.Matches(text, search).Count;
        }

        public static bool EqualsIgnoreCase(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool StartsWithIgnoreCase(this string a, string b)
        {
            return a.StartsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool EndsWithIgnoreCase(this string a, string b)
        {
            return a.EndsWith(b, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static int NthIndexOf(this string str, string match, int occurrence)
        {
            int i = 1;
            int index = 0;

            while (i <= occurrence && (index = str.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurrence) return index;
                i++;
            }
            return -1;
        }

        public static string IfNullThen(this string input, string nullAlternateValue)
        {
            return (!string.IsNullOrWhiteSpace(input)) ? input : nullAlternateValue;
        }

        public static bool IsAlphaNumeric(this string str)
        {
            return !Regex.IsMatch(str, "[^a-zA-Z0-9]");
        }
        public static bool IsAlpha(this string str)
        {
            return !Regex.IsMatch(str, "[^a-zA-Z]");
        }

        public static bool IsNumeric(this string str)
        {
            return !Regex.IsMatch(str, "[^0-9]");
        }

        public static bool IsAnagram(this string thisString, string otherString)
        {
            return thisString
                .OrderBy(c => c)
                .SequenceEqual(otherString.OrderBy(c => c));
        }

        public static bool IsPalindrome(this string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static bool IsValidEmail(this string str)
        {
            return Regex.IsMatch(str, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$");
        }

        public static bool IsValidIP(this string str)
        {
            return Regex.IsMatch(str, @"^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$");
        }
    }
}
#endif
