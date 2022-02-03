using System;

namespace adduo.elephant.console
{
    public static class Extensions
    {
        public static int GetMonthDifference(this DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart) + 1;
        }
    }
}
