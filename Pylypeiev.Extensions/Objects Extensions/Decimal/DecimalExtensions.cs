using System;

namespace Pylypeiev.Extensions
{
    public static class DecimalExtensions
    {
        /// <summary>Returns the absolute value of this number.</summary>
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        /// <summary>Returns the smallest integral value that is greater than or equal to the specified number</summary>
        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }

        /// <summary>Returns the largest integral value that is greater than or equal to the specified number</summary>
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static decimal GetPercentage(this decimal value, decimal percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this decimal number, decimal a, decimal b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static decimal Max(this decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static decimal Min(this decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        ///  Rounds a decimal value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <exception cref="System.OverflowException">The result is outside the range</exception>
        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        /// <summary>
        ///  Rounds a decimal value to the nearest integral value, and rounds midpoint values
        ///  to the nearest even number.
        /// </summary>
        /// <param name="decimals">The number of decimal places in the return value.</param>
        /// <exception cref="System.OverflowException">The result is outside the range</exception>
        public static decimal Round(this decimal d, int decimals)
        {
            return Math.Round(d, decimals);
        }

        /// <summary>Add a number to this number </summary>
        public static decimal Plus(this decimal value, decimal value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static decimal Minus(this decimal value, decimal value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static decimal DivideBy(this decimal value, decimal value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static decimal MultiplyBy(this decimal value, decimal value2)
        {
            return value / value2;
        }
    }
}