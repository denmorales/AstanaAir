namespace AstanaAir.Domain.Extentions;

public static class DateTimeExtensions
{
    public static DateTimeOffset FromLocalTime(this DateTime dateTime, short offset) =>
        new(
            dateTime.Year,
            dateTime.Month,
            dateTime.Day,
            dateTime.Hour,
            dateTime.Minute,
            0,
            TimeSpan.FromHours(offset));
}