using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class DictionaryExtensions
    {
        /// <summary> Add an element with provided key to dictionary if this key is not exist yet </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="value"> The object to use as a value </param>
        /// <exception cref="System.ArgumentNullException">key is null</exception>
        /// <returns> True if added to dictionary, otherwise, false. </returns>
        [DebuggerStepThrough]
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict?.ContainsKey(key) == false)
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
        [DebuggerStepThrough]
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict == null || key == null)
            {
                return default;
            }

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

        /// <summary>
        /// Convert this dictionary to list of Tuples, where item1 is key and item2 is a value from this dictionary
        /// </summary>
        /// <returns>List with tuples</returns>
        [DebuggerStepThrough]
        public static List<Tuple<TKey, TValue>> ToTuple<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            if (dict == null || dict.Count == 0)
            {
                return new List<Tuple<TKey, TValue>>(0);
            }

            var tuples = new List<Tuple<TKey, TValue>>(dict.Count);

            foreach (var val in dict)
            {
                tuples.Add(Tuple.Create(val.Key, val.Value));
            }

            return tuples;
        }

        /// <summary> Get an element with provided key if this key is exist, otherwise default value </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="defaultValue"> TValue that will be returned if key is not exist</param>
        /// <returns> Get an element with provided key if this key is exist, otherwise default value </returns>
        [DebuggerStepThrough]
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
        {
            if (dict.TryGetValue(key, out TValue value))
            {
                return value;
            }

            return defaultValue;
        }

        /// <summary> Converts collection of key/value pairs to read only one </summary>
        /// <returns>Read only collection wrapping a collection of key/value pairs, if dictionary is null than empty collection</returns>
        [DebuggerStepThrough]
        public static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                return new ReadOnlyDictionary<TKey, TValue>(new Dictionary<TKey, TValue>());
            }

            return new ReadOnlyDictionary<TKey, TValue>(dictionary);
        }
    }
}