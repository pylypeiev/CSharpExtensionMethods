using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pylypeiev.Extensions
{
    public static class IEnumerableExtensions
    {
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
    }
}
