using System;

namespace Pylypeiev.Extensions
{
    public static class LongExtensions
    {
        public static bool IsBetween(this long number, long a, long b)
        {
            return a <= number && number <= b;
        }

        public static long Max(this long val1, long val2)
        {
            return Math.Max(val1, val2);
        }

        public static long Min(this long val1, long val2)
        {
            return Math.Min(val1, val2);
        }

        public static double GetPercentage(this long value, long percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

        public static string ToFileSize(this long size)
        {
            if (size < 1024) { return (size).ToString("F0") + " bytes"; }
            if (size < Math.Pow(1024, 2)) { return (size / 1024).ToString("F0") + "KB"; }
            if (size < Math.Pow(1024, 3)) { return (size / Math.Pow(1024, 2)).ToString("F0") + "MB"; }
            if (size < Math.Pow(1024, 4)) { return (size / Math.Pow(1024, 3)).ToString("F0") + "GB"; }
            if (size < Math.Pow(1024, 5)) { return (size / Math.Pow(1024, 4)).ToString("F0") + "TB"; }
            if (size < Math.Pow(1024, 6)) { return (size / Math.Pow(1024, 5)).ToString("F0") + "PB"; }
            return (size / Math.Pow(1024, 6)).ToString("F0") + "EB";
        }
    }
}
