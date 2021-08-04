using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pylypeiev.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary> Add the object top the end of IEnumerable </summary>
        /// <param name="element">object to append</param>
        /// <returns>updated IEnumerable</returns>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> source, T element)
        {
            foreach (var item in source)
            {
                yield return item;
            }

            yield return element;
        }

        /// <summary> Check if all elements in IEnumerable are equals </summary>
        /// <exception cref="System.ArgumentNullException">enumerable is null</exception>
        /// <returns>true if they are equals, otherwise - false</returns>
        public static bool AreAllSame<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            using (var enumerator = enumerable.GetEnumerator())
            {
                var toCompare = default(T);
                if (enumerator.MoveNext())
                {
                    toCompare = enumerator.Current;
                }

                while (enumerator.MoveNext())
                {
                    if (toCompare != null && !toCompare.Equals(enumerator.Current))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Concatenates the elements of an IEnumerable<string> to 1 string. Uses StringBuilder
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns>concatenated string</returns>
        public static string Concatenate(this IEnumerable<string> enumerable)
        {
            var sb = new StringBuilder();

            foreach (var s in enumerable)
            {
                sb.Append(s);
            }

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
            if (collection != null)
            {
                foreach (T item in collection)
                {
                    action(item);
                }
            }

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
        public static string Join<T>(this IEnumerable<T> source, string separator)
        {
            if (source == null)
            {
                return string.Empty;
            }

            return string.Join(separator, source.Select(e => e.ToString()).ToArray());
        }

        /// <summary> Add the object at the beginning of IEnumerable </summary>
        /// <param name="element">object to prepend</param>
        /// <returns>updated IEnumerable</returns>
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T element)
        {
            yield return element;
            foreach (var item in source)
            {
                yield return item;
            }
        }

        /// <summary> Shuffle IEnumerable </summary>
        /// <returns> a random shuffled IEnumerable or empty collection if source is null</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                return Enumerable.Empty<T>();
            }

            return source.OrderBy(_ => Guid.NewGuid());
        }

        /// <summary>Pick a random element from IEnumerable</summary>
        /// <returns> 1 random element of type T, ot default T if collection is null </returns>
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                return default;
            }

            return source.PickRandom(1).Single();
        }

        /// <summary>Pick N random elements from IEnumerable</summary>
        /// <param name="count">number of objects of type T to pick</param>
        /// <returns> IEnumerable collecting N random element of type T, or empty enumerable if collection is null </returns>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            if (source == null)
            {
                return Enumerable.Empty<T>();
            }

            return source.Shuffle().Take(count);
        }

        /// <summary>Safe foreach and more, returns an empty Enumerable if source is null. </summary>
        /// <returns> Source if not null, otherwise Enumerable.Empty </returns>
        public static IEnumerable<T> ThisOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable ?? Enumerable.Empty<T>();
        }
    }
}