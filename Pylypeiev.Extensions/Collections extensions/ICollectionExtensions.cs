using System.Collections;
using System.Collections.Generic;

namespace Pylypeiev.Extensions
{
    public static class ICollectionExtensions
    {
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
    }
}
