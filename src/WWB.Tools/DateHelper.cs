using System;

namespace WWB.Tools
{
    public static class DateHelper
    {
        public static long DateTimeToUnixTime(DateTime dateTime)
        {
            return (dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }

        public static DateTime UnixTimeToDateTime(long timeStamp)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区

            return startTime.AddTicks(timeStamp * 10000000);
        }
    }
}