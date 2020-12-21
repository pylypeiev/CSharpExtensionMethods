using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pylypeiev.Extensions
{
    public static class ObjectGeneralExtensions
    {
        /// <summary>Perform action on the object if it not null</summary>
        /// <param name="action">action to perform</param>
        public static void IfNotNull<T>(this T obj, Action<T> action) where T : class
        {
            if (obj != null)
                action(obj);
        }

        /// <summary>Perform function on the object if it not null</summary>
        /// <param name="func">function to perform</param>
        /// <returns>return function result or default value of the object if it is null</returns>
        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func) where T : class
        {
            return obj != null ? func(obj) : default;
        }

        /// <summary>Perform function on the object if it not null, otherwise return default value</summary>
        /// <param name="func">function to perform</param>
        /// <param name="defaultValue">default value if object is null</param>
        /// <returns>return function result or default value of the object if it is null</returns>
        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            return obj != null ? func(obj) : defaultValue;
        }

        /// <summary>Check if object equals to its a default value</summary>
        /// <param name="source"></param>
        /// <returns>True is object equals to its a default value, otherwise false</returns>
        public static bool IsDefaultValue<T>(this T source)
        {
            return source.Equals(default(T));
        }

        /// <summary>Determines if an object is contained in a sequence</summary>
        /// <param name="sequence"></param>
        /// <exception cref="System.ArgumentNullException">object is null</exception>
        /// <returns>true if object is contained in sequence, otherwise - false</returns>
        public static bool IsIn<T>(this T obj, params T[] sequence)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            return sequence.Contains(obj);
        }

        /// <summary>Check if object is NOT null</summary>
        /// <returns>true if object is not null, otherwise - false</returns>
        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        /// <summary>Check if object is null</summary>
        /// <returns>true if object is null, otherwise - false</returns>
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        /// <summary>like ToString of the object, but not crushes if the object is null</summary>
        /// <returns>ToString of the object, if the object is null - empty string</returns>
        public static string ToStringSafe(this object str)
        {
            return str == null ? "" : str.ToString();
        }

        /// <summary>
        /// try to perform a function on the object, if not succeed return default value of the object
        /// </summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <returns>result of the function or a default value if not succeed </returns>
        public static TResult Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction)
        {
            try
            {
                return tryFunction(obj);
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// try to perform a function on the object, if not succeed return catchValue
        /// </summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="catchValue">value to return if not succeed</param>
        /// <returns>result of the function or a catchValue if not succeed </returns>
        public static TResult Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, TResult catchValue)
        {
            try
            {
                return tryFunction(obj);
            }
            catch
            {
                return catchValue;
            }
        }

        /// <summary>try to perform a function on the object and return an object with out parameter</summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="result">result of try function</param>
        /// <returns>return true if the function succeeded and result accordingly, otherwise - false and default value of result</returns>
        public static bool Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, out TResult result)
        {
            try
            {
                result = tryFunction(obj);
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        /// <summary>try to perform a function on the object and return an object with out parameter</summary>
        /// <param name="tryFunction">function to try to perform</param>
        /// <param name="catchValue">value to return if not succeed</param>
        /// <param name="result">result of try function</param>
        /// <returns>return true if the function succeeded and result accordingly, otherwise - false and catchValue</returns>
        public static bool Try<TType, TResult>(this TType obj, Func<TType, TResult> tryFunction, TResult catchValue, out TResult result)
        {
            try
            {
                result = tryFunction(obj);
                return true;
            }
            catch
            {
                result = catchValue;
                return false;
            }
        }

        /// <summary>try to perform an action on the object</summary>
        /// <param name="tryAction">action to try to perform</param>
        /// <returns>true if the action succeeded, otherwise - false</returns>
        public static bool Try<TType>(this TType obj, Action<TType> tryAction)
        {
            try
            {
                tryAction(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>try to perform an action on the object, if not succeeded - perform another action</summary>
        /// <param name="tryAction">action to try to perform</param>
        /// <param name="catchAction">action to perform if first action not succeeded </param>
        /// <returns>true if first action succeeded, otherwise - false</returns>
        public static bool Try<TType>(this TType obj, Action<TType> tryAction, Action<TType> catchAction)
        {
            try
            {
                tryAction(obj);
                return true;
            }
            catch
            {
                catchAction(obj);
                return false;
            }
        }

        /// <summary>Wraps this object instance into an IEnumerable, consisting of a single item.</summary>
        /// <param name="item"> The instance that will be wrapped.</param>
        /// <returns> An IEnumerable of a single item. </returns>
        public static IEnumerable<T> Yield<T>(this T item)
        {
            yield return item;
        }

        /// <summary>Deep copy of object using BinaryFormatter</summary>
        /// <param name="source"> An object to copy</param>
        /// <returns> An deep copy of object of type T</returns>
        public static T DeepCopy<T>(this T source)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, source);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}