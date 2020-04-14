using System;
using System.Linq;

namespace Pylypeiev.Extensions
{
    public static class ObjectGeneralExtensions
    {
        public static bool IsIn<T>(this T source, params T[] list)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return list.Contains(source);
        }

        public static bool IsDefault<T>(this T source)
        {
            return source.Equals(default(T));
        }

        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        public static void IfNotNull<T>(this T obj, Action<T> action) where T : class
        {
            if (obj != null)
                action(obj);
        }

        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func) where T : class
        {
            return obj != null ? func(obj) : default;
        }

        public static TResult IfNotNull<T, TResult>(this T obj, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            return obj != null ? func(obj) : defaultValue;
        }

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

        public static string ToStringSafe(this object str)
        {
            return str == null ? "" : str.ToString();
        }
    }
}
