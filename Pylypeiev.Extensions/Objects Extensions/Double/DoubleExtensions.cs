using System;

namespace Pylypeiev.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>Returns the absolute value of this number.</summary>
        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }

        /// <summary>Returns the smallest integral value that is greater than or equal to the specified number</summary>
        public static double Ceiling(this double value)
        {
            return Math.Ceiling(value);
        }

        /// <summary>Returns the largest integral value that is greater than or equal to the specified number</summary>
        public static double Floor(this double value)
        {
            return Math.Floor(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static double GetPercentage(this double value, double percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this double number, double a, double b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static double Max(this double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///  Rounds a double value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        /// <summary>
        ///  Rounds a double value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <param name="doubles">The number of fractional digits in the return value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">doubles is less than 0 or greater than 15</exception>
        public static double Round(this double d, int doubles)
        {
            return Math.Round(d, doubles);
        }

        /// <summary>Add a number to this number </summary>
        public static double Plus(this double value, double value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static double Minus(this double value, double value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static double DivideBy(this double value, double value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static double MultiplyBy(this double value, double value2)
        {
            return value * value2;
        }
    }
}