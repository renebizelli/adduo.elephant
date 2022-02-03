using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace adduo.elephant.utilities.extensionmethods
{
    public static class DateTimeExtensionMethod
    {
        public static DateTime AjustNow(this DateTime dt, int hoursAjust = 4)
        {
            return dt.AddHours(hoursAjust);
        }

        public static string ToMySQL(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
        }

        public static long TicksOrZero(this DateTime? dt)
        {
            return dt.HasValue ? dt.Value.Ticks : 0;
        }

        public static int GetNumberOfWeek(this DateTime dateTime)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
    }
}
