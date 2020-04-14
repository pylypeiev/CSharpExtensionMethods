using System;

namespace Pylypeiev.Extensions
{
    public static class DateTimeOperationsExtensions
    {
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
    }
}
