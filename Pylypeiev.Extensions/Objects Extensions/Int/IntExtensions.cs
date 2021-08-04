using System;

namespace Pylypeiev.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static double GetPercentage(this int value, int percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this int number, int a, int b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static int Max(this int val1, int val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static int Min(this int val1, int val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>Format file size in KB/MB/GB/TB/PB/EB</summary>
        /// <param name="size">size in bytes</param>
        /// <returns>string representation of file size</returns>
        public static string ToFileSize(this int size)
        {
            if (size < 1024) { return (size).ToString("F0") + " bytes"; }
            if (size < Math.Pow(1024, 2)) { return (size / 1024).ToString("F0") + "KB"; }
            if (size < Math.Pow(1024, 3)) { return (size / Math.Pow(1024, 2)).ToString("F0") + "MB"; }
            if (size < Math.Pow(1024, 4)) { return (size / Math.Pow(1024, 3)).ToString("F0") + "GB"; }
            if (size < Math.Pow(1024, 5)) { return (size / Math.Pow(1024, 4)).ToString("F0") + "TB"; }
            if (size < Math.Pow(1024, 6)) { return (size / Math.Pow(1024, 5)).ToString("F0") + "PB"; }
            return (size / Math.Pow(1024, 6)).ToString("F0") + "EB";
        }

        /// <summary>Add a number to this number </summary>
        public static int Plus(this int value, int value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static int Minus(this int value, int value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static int DivideBy(this int value, int value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static int MultiplyBy(this int value, int value2)
        {
            return value * value2;
        }
    }
}