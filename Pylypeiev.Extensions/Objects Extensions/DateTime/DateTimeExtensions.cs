using System;
using System.Diagnostics;

namespace Pylypeiev.Extensions
{
    [DebuggerStepThrough]
    public static class DateTimeCalculationsExtensions
    {
        /// <summary>Check if date is between 2 dates. Inclusive.</summary>
        /// <param name="start">from date</param>
        /// <param name="end">to date</param>
        /// <returns>true if date is between, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool Between(this DateTime date, DateTime start, DateTime end)
        {
            return date.Ticks >= start.Ticks && date.Ticks <= end.Ticks;
        }

        /// <summary> Calculate age </summary>
        /// <returns> age in numbers</returns>
        [DebuggerStepThrough]
        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age))
            {
                age--;
            }

            return age;
        }

        /// <summary>
        /// Get time from this DateTime in numbers format.
        /// </summary>
        /// <param name="timeFormat">string format applied on DateTime, please provide only time-specified formats</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static int GetTime(this DateTime date, string timeFormat = "HHmmss")
        {
            return date.ToString(timeFormat).ToInt();
        }

        /// <summary>Check if this date is future </summary>
        /// <param name="from">date from. Exclusive</param>
        /// <returns>true if the date is in future, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool IsFuture(this DateTime date, DateTime from)
        {
            return date.Date > from.Date;
        }

        /// <summary>Check if this date is future </summary>
        /// <returns>true if the date is in future, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool IsFuture(this DateTime date)
        {
            return date.IsFuture(DateTime.Now);
        }

        /// <summary>Check if this date is past </summary>
        /// <param name="from">date from. Exclusive</param>
        /// <returns>true if the date is in past, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool IsPast(this DateTime date, DateTime from)
        {
            return date.Date < from.Date;
        }

        /// <summary>Check if this date is past </summary>
        /// <returns>true if the date is in past, otherwise - false</returns>
        [DebuggerStepThrough]
        public static bool IsPast(this DateTime date)
        {
            return date.IsPast(DateTime.Now);
        }

        /// <summary>
        /// Check if this DateTime is default, empty value
        /// </summary>
        /// <returns>true if </returns>
        [DebuggerStepThrough]
        public static bool IsDefault(this DateTime target)
        {
            return target == default;
        }

        /// <summary>convert date to UNIX Epoch time format</summary>
        /// <returns>number of milliseconds (including fractions) in UTC between the specified date and midnight January 1, 1970.</returns>
        [DebuggerStepThrough]
        public static double ToUnixTime(this DateTime localTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return localTime.ToUniversalTime()
                            .Subtract(epoch)
                            .TotalMilliseconds;
        }

        /// <summary> Trims millisecond component so that the precision of the resulting time is to the second</summary>
        /// <returns>new DateTime with precision of the time is to the seconds</returns>
        [DebuggerStepThrough] public static DateTime TrimToSecond(this DateTime time) => new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second, time.Kind);

        /// <summary>
        /// Trims the second and millisecond components so that the
        /// precision of the resulting time is to the minutes
        /// </summary>
        /// <returns>new DateTime with precision of the time is to the minutes</returns>
        [DebuggerStepThrough] public static DateTime TrimToMinute(this DateTime time) => new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, 0, time.Kind);

        /// <summary>
        /// Trims the minute, second and millisecond components so that the
        /// precision of the resulting time is to the hour
        /// </summary>
        /// <returns>new DateTime with precision of the time is to the hour</returns>
        [DebuggerStepThrough] public static DateTime TrimToHour(this DateTime time) => new DateTime(time.Year, time.Month, time.Day, time.Hour, 0, 0, time.Kind);

        /// <summary>
        /// Trims the time components so that the precision of the resulting
        /// time is to the day
        /// </summary>
        /// <returns>new DateTime with precision of the time is to the day</returns>
        [DebuggerStepThrough] public static DateTime TrimToDay(this DateTime time) => time.Date;

        /// <summary>Determines the quarter (from 1 to 4) to which the date belongs</summary>
        /// <returns>the quarter (from 1 to 4) to which this date belongs.</returns>
        [DebuggerStepThrough] public static int GetQuarter(this DateTime date) => ((date.Month - 1) / 3) + 1;
    }
}