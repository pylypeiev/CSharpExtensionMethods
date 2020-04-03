using System;

namespace Pylypeiev.Extensions
{

    public static class DateTimeExtensions
    {
        #region Operations
        public static DateTime[] GetDatesArray(this DateTime fromDate, DateTime toDate)
        {
            int days = (toDate - fromDate).Days;
            var dates = new DateTime[days];

            for (int i = 0; i < days; i++)
            {
                dates[i] = fromDate.AddDays(i);
            }

            return dates;
        }

        public static int GetTime(this DateTime date, string timeFormat = "HHmmss")
        {
            return date.ToString(timeFormat).ToInt();
        }
        #endregion

        #region Calculations
        public static bool Between(this DateTime date, DateTime start, DateTime end)
        {
            return date.Ticks >= start.Ticks && date.Ticks <= end.Ticks;
        }

        public static int CalculateAge(this DateTime dateTime)
        {
            var age = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now < dateTime.AddYears(age)) age--;
            return age;
        }

        public static bool IsFuture(this DateTime date, DateTime from)
        {
            return date.Date > from.Date;
        }

        public static bool IsFuture(this DateTime date)
        {
            return date.IsFuture(DateTime.Now);
        }

        public static bool IsPast(this DateTime date, DateTime from)
        {
            return date.Date < from.Date;
        }

        public static bool IsPast(this DateTime date)
        {
            return date.IsPast(DateTime.Now);
        }
        #endregion
    }
}
