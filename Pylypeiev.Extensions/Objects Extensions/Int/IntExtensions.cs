using System;

namespace Pylypeiev.Extensions
{
    public static class IntExtensions
    {
        public static bool IsBetween(this int number, int a, int b)
        {
            return a <= number && number <= b;
        }

        public static int Max(this int val1, int val2)
        {
            return Math.Max(val1, val2);
        }

        public static int Min(this int val1, int val2)
        {
            return Math.Min(val1, val2);
        }

        public static double GetPercentage(this int value, int percentage)
        {
            var percentAsDouble = (double)percentage / 100;
            return value * percentAsDouble;
        }

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
    }
}
