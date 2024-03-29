﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class ICollectionExtensions
    {
        /// <summary>Add an element to the end of the collection if this value is not exist yet</summary>
        /// <param name="value"> The object to add</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        /// <returns> True if added to collection, otherwise, false. </returns>
        [DebuggerStepThrough]
        public static bool AddIfNotContains<T>(this ICollection<T> collection, T value)
        {
            if (collection?.Contains(value) == false)
            {
                collection.Add(value);
                return true;
            }
            return false;
        }

        /// <summary> Adds the elements of the specified Array to the end of the collection </summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        [DebuggerStepThrough]
        public static void AddRange<T>(this ICollection<T> collection, params T[] values)
        {
            if (collection != null && values != null)
            {
                foreach (T value in values)
                {
                    collection.Add(value);
                }
            }
        }

        /// <summary>Adds the elements of the specified IEnumerable to the end of the collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        [DebuggerStepThrough]
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable values)
        {
            if (collection != null && values != null)
            {
                foreach (T value in values)
                {
                    collection.Add(value);
                }
            }
        }

        /// <summary> Check if collection is null or empty </summary>
        /// <returns>true if collection is not null and not empty, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }

        /// <summary>Removes a range of elements from collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        [DebuggerStepThrough]
        public static void RemoveRange<T>(this ICollection<T> collection, params T[] values)
        {
            if (collection != null && values != null)
            {
                foreach (T value in values)
                {
                    collection.Remove(value);
                }
            }
        }

        /// <summary>Removes a range of elements from collection</summary>
        /// <param name="values">values</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        [DebuggerStepThrough]
        public static void RemoveRange<T>(this ICollection<T> collection, IEnumerable values)
        {
            if (collection != null && values != null)
            {
                foreach (T value in values)
                {
                    collection.Remove(value);
                }
            }
        }
    }
}