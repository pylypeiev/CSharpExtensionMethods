using System;
using System.Collections.Generic;
using System.Linq;

namespace Pylypeiev.Extensions
{
    public static class IListExtensions
    {
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
    }
}