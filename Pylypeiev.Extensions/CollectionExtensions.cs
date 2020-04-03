using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pylypeiev.Extensions
{
    public static class CollectionExtensions
    {
        #region IEnumerable Extensions
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

        #endregion

        #region Array Extensions
        public static string Join(this Array array, string separator)
        {
            return string.Join(separator, array);
        }

        #endregion

        #region ICollection Extensions
        public static bool IsNullOrEmpty(this ICollection obj)
        {
            return obj == null || obj.Count == 0;
        }

        #endregion

        #region IList Extensions

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

        #endregion
    }
}
