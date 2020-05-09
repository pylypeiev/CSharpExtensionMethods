using System.Collections.Generic;

namespace Pylypeiev.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary> Add an element with provided key to dictionary if this key is not exist yet </summary>
        /// <param name="key"> The object to use as a key </param>
        /// <param name="value"> The object to use as a value </param>
        /// <exception cref="System.ArgumentNullException">key is null</exception>
        /// <returns> True if added to dictionary, otherwise, false. </returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key))
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
    }
}
