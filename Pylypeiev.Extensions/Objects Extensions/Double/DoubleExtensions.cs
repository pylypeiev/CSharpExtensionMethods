using System;

namespace Pylypeiev.Extensions
{
    public static class DoubleExtensions
    {
        public static bool IsBetween(this double number, double a, double b)
        {
            return a <= number && number <= b;
        }

        public static double GetPercentage(this double value, double percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }

        public static double Ceiling(this double value)
        {
            return Math.Ceiling(value);
        }
        public static double Floor(this double value)
        {
            return Math.Floor(value);
        }

        public static double Max(this double val1, double val2)
        {
            return Math.Max(val1, val2);
        }

        public static double Min(this double val1, double val2)
        {
            return Math.Min(val1, val2);
        }

        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        public static double Round(this double d, Int32 doubles)
        {
            return Math.Round(d, doubles);
        }
    }
}
