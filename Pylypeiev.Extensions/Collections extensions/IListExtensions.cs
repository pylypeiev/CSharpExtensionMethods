﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class IListExtensions
    {
        /// <summary> Chunk a list to smaller lists with a maximum capacity of the chunk size</summary>
        /// <param name="chunkSize"> a maximum capacity of the chunk size</param>
        /// <returns>List with chunked lists</returns>
        [DebuggerStepThrough]
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            if (source == null)
            {
                return new List<List<T>>(0);
            }

            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        /// <summary>Clone an collection to new IList</summary>
        /// <returns>cloned new IList</returns>
        [DebuggerStepThrough]
        public static IList<T> Clone<T>(this IList<T> list) where T : ICloneable
        {
            if (list == null)
            {
                return new List<T>(0);
            }

            var cloned = new List<T>(list.Count);
            foreach (var item in list)
            {
                cloned.Add((T)item.Clone());
            }

            return cloned;
        }

        /// <summary> Adds an object to the collection and return this collection for fluent api</summary>
        /// <param name="item"> The object to add</param>
        /// <exception cref="System.NotSupportedException">collection is read only</exception>
        /// <returns>this collection</returns>
        [DebuggerStepThrough]
        public static TList Push<TList, TItem>(this TList list, TItem item) where TList : IList<TItem>
        {
            if (list == null)
            {
                return default;
            }

            list.Add(item);
            return list;
        }

        /// <summary>
        /// Get all permutations for this List. Please use only if you need this, memory and GC is under your responsibility!
        /// </summary>
        /// <returns>all permutations for this List, or empty collection if the list is null</returns>
        [DebuggerStepThrough]
        public static List<List<T>> GetPermutations<T>(this List<T> list)
        {
            if (list == null)
            {
                return new List<List<T>>(0);
            }

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

        /// <summary> Converts collection to read only one </summary>
        /// <returns>Read only collection wrapping, if list is null than empty collection</returns>
        [DebuggerStepThrough]
        public static IList<T> AsReadOnly<T>(this IList<T> list)
        {
            if (list == null)
            {
#if NET451
                return new ReadOnlyCollection<T>(new T[0]);
#else
                return new ReadOnlyCollection<T>(Array.Empty<T>());
#endif
            }

            return list.IsReadOnly
                        ? list
                        : new ReadOnlyCollection<T>(list);
        }
    }
}