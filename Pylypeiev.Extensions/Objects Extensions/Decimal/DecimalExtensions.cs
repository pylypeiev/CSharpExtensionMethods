using System;

namespace Pylypeiev.Extensions
{
    public static class DecimalExtensions
    {
        public static bool IsBetween(this decimal number, decimal a, decimal b)
        {
            return a <= number && number <= b;
        }
        public static decimal GetPercentage(this decimal value, decimal percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }

        public static decimal Max(this decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }

        public static decimal Min(this decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }

        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        public static decimal Round(this decimal d, Int32 decimals)
        {
            return Math.Round(d, decimals);
        }
    }
}
