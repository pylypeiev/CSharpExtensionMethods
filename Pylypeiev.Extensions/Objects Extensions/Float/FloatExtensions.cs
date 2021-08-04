using System;

namespace Pylypeiev.Extensions
{
    public static class FloatExtensions
    {
        /// <summary>Returns the absolute value of this number.</summary>
        public static float Abs(this float value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// Calculate percentage from this number
        /// </summary>
        /// <param name="percentage">percentage number</param>
        public static float GetPercentage(this float value, float percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        /// <summary>Check if this number is between 2 numbers</summary>
        /// <param name="a">lower bound</param>
        /// <param name="b">upper bound</param>
        /// <returns>true if between, otherwise - false</returns>
        public static bool IsBetween(this float number, float a, float b)
        {
            return a <= number && number <= b;
        }

        /// <summary>Returns the larger of two numbers</summary>
        public static float Max(this float val1, float val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>Returns the smaller of two numbers</summary>
        public static float Min(this float val1, float val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>Add a number to this number </summary>
        public static float Plus(this float value, float value2)
        {
            return value + value2;
        }

        /// <summary>Subtract a number from this number </summary>
        public static float Minus(this float value, float value2)
        {
            return value - value2;
        }

        /// <summary>Divide this number by given number</summary>
        public static float DivideBy(this float value, float value2)
        {
            return value / value2;
        }

        /// <summary>Multiply this number by given number</summary>
        public static float MultiplyBy(this float value, float value2)
        {
            return value * value2;
        }
    }
}
