namespace ZyloApp.Web.Extensions;
public static class DateTimeExtensions
{
    private static readonly TimeZoneInfo NepalZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kathmandu");

    public static DateTime ToNepalTime(this DateTime dateTime)
    {
        return TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Utc, NepalZone);
    }

    public static DateTime ToNepalTime(this DateTime? dateTime)
    {
        if (dateTime is null)
            return DateTime.MinValue;

        return TimeZoneInfo.ConvertTime(dateTime.Value, TimeZoneInfo.Utc, NepalZone);
    }

    public static TimeOnly ToNepalTime(this TimeOnly? time, DateOnly date)
    {
        if (!time.HasValue)
            return TimeOnly.MinValue;

        var utcDateTime = date.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc).Add(time.Value.ToTimeSpan());
        var nepalDateTime = TimeZoneInfo.ConvertTime(utcDateTime, TimeZoneInfo.Utc, NepalZone);
        return TimeOnly.FromDateTime(nepalDateTime);
    }

    public static DateTime[] Until(this DateTime start, DateTime end)
    {
        List<DateTime> dates = [];

        for(var counter = start; counter <= end; counter = counter.AddDays(1))
        {
            dates.Add(counter);
        }

        return [.. dates];
    }

    public static bool IsOfficeDay(this DateTime date)
    {
        var isWeekend = date.DayOfWeek == DayOfWeek.Saturday;
        return !isWeekend;
    }
}
