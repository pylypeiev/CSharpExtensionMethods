using System;
using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class FuncExtensions
    {
        /// <summary> Combines two Predicate<T> to form a logical OR</summary>
        [DebuggerStepThrough]
        public static Predicate<T> Or<T>(this Predicate<T> first, Predicate<T> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return x => first(x) || second(x);
        }

        /// <summary> Combines two Func<T, bool> to form a logical OR</summary>
        [DebuggerStepThrough]
        public static Func<bool> Or(this Func<bool> first, Func<bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return () => first() || second();
        }

        /// <summary> Combines two Func<T, bool> to form a logical OR</summary>
        [DebuggerStepThrough]
        public static Func<T, bool> Or<T>(this Func<T, bool> first, Func<T, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return x => first(x) || second(x);
        }

        /// <summary> Combines two Func<T,K, bool> to form a logical OR</summary>
        [DebuggerStepThrough]
        public static Func<T, K, bool> Or<T, K>(this Func<T, K, bool> first, Func<T, K, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return (x, y) => first(x, y) || second(x, y);
        }

        /// <summary> Combines two Func<T,K,V, bool> to form a logical OR</summary>
        [DebuggerStepThrough]
        public static Func<T, K, V, bool> Or<T, K, V>(this Func<T, K, V, bool> first, Func<T, K, V, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return (x, y, z) => first(x, y, z) || second(x, y, z);
        }

        /// <summary> Combines two Predicate<T> to form a logical AND</summary>
        [DebuggerStepThrough]
        public static Predicate<T> And<T>(this Predicate<T> first, Predicate<T> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return obj => first(obj) && second(obj);
        }

        /// <summary> Combines two Func<T, bool> to form a logical AND</summary>
        [DebuggerStepThrough]
        public static Func<bool> And(this Func<bool> first, Func<bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return () => first() && second();
        }

        /// <summary> Combines two Func<T, bool> to form a logical AND</summary>
        [DebuggerStepThrough]
        public static Func<T, bool> And<T>(this Func<T, bool> first, Func<T, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return x => first(x) && second(x);
        }

        /// <summary> Combines two Func<T,K, bool> to form a logical AND</summary>
        [DebuggerStepThrough]
        public static Func<T, K, bool> And<T, K>(this Func<T, K, bool> first, Func<T, K, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return (x, y) => first(x, y) && second(x, y);
        }

        /// <summary> Combines two Func<T,K,V, bool> to form a logical AND</summary>
        [DebuggerStepThrough]
        public static Func<T, K, V, bool> And<T, K, V>(this Func<T, K, V, bool> first, Func<T, K, V, bool> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second == null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            return (x, y, z) => first(x, y, z) && second(x, y, z);
        }
    }
}