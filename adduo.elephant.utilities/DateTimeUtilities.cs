using System;

namespace adduo.elephant.utilities
{
    public class DateTimeUtilities
    {
        public static DateTime Now()
        {
            return DateTime.Now;
        }

        public static DateTime TimestampToDateTime(int timestamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp);
        }

        public static double Timestamp(TimeSpan adicionar)
        {
            var ts = Now() - (new DateTime(1970, 1, 1, 0, 0, 0));

            ts.Add(adicionar);

            return ts.TotalSeconds;
        }

        public static double Timestamp()
        {
            var ts = Now() - (new DateTime(1970, 1, 1, 0, 0, 0));

            return ts.TotalSeconds;
        }
    }
}
