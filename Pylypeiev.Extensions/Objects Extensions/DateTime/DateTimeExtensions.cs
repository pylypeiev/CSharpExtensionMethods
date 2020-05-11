using System;

namespace Pylypeiev.Extensions
{

    public static class DateTimeCalculationsExtensions
    {
        /// <summary>Check if date is between 2 dates. Inclusive.</summary>
        /// <param name="start">from date</param>
        /// <param name="end">to date</param>
        /// <returns>true if date is between, otherwise - false</returns>
        public static bool Between(this DateTime date, DateTime start, DateTime end)
        {
            return date.Ticks >= start.Ticks && date.Ticks <= end.Ticks;
        }

        /// <summary> Calculate age </summary>
        /// <returns> age in numbers</returns>
        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age)) age--;
            return age;
        }

        /// <summary>Check if this date is future </summary>
        /// <param name="from">date from. Exclusive</param>
        /// <returns>true if the date is in future, otherwise - false</returns>
        public static bool IsFuture(this DateTime date, DateTime from)
        {
            return date.Date > from.Date;
        }

        /// <summary>Check if this date is future </summary>
        /// <returns>true if the date is in future, otherwise - false</returns>
        public static bool IsFuture(this DateTime date)
        {
            return date.IsFuture(DateTime.Now);
        }

        /// <summary>Check if this date is past </summary>
        /// <param name="from">date from. Exclusive</param>
        /// <returns>true if the date is in past, otherwise - false</returns>
        public static bool IsPast(this DateTime date, DateTime from)
        {
            return date.Date < from.Date;
        }

        /// <summary>Check if this date is past </summary>
        /// <returns>true if the date is in past, otherwise - false</returns>
        public static bool IsPast(this DateTime date)
        {
            return date.IsPast(DateTime.Now);
        }

        /// <summary>
        /// Get time from this DateTime in numbers format.
        /// </summary>
        /// <param name="timeFormat">string format applied on DateTime, please provide only time-specified formats</param>
        /// <returns></returns>
        public static int GetTime(this DateTime date, string timeFormat = "HHmmss")
        {
            return date.ToString(timeFormat).ToInt();
        }
    }
}
