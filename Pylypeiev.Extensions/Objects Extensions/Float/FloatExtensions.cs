using System;

namespace Pylypeiev.Extensions
{
    public static class FloatExtensions
    {
        public static bool IsBetween(this float number, float a, float b)
        {
            return a <= number && number <= b;
        }

        public static float GetPercentage(this float value, float percentage)
        {
            var percentAsDouble = percentage / 100;
            return value * percentAsDouble;
        }

        public static float Abs(this float value)
        {
            return Math.Abs(value);
        }

        public static float Max(this float val1, float val2)
        {
            return Math.Max(val1, val2);
        }

        public static float Min(this float val1, float val2)
        {
            return Math.Min(val1, val2);
        }
    }
}
