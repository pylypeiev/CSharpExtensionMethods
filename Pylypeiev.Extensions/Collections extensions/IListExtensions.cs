using System;
using System.Collections.Generic;
using System.Linq;

namespace Pylypeiev.Extensions
{

    public static class IListExtensions
    {
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
    }
}
